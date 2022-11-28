using System.Data;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

using Curtains.Domain.Models;

namespace Curtains.Infrastructure.Database
{
    public class CurtainsDbContext : DbContext
    {
        private IDbContextTransaction _currentTransaction;

        #region DbSetsRegion
        public virtual DbSet<AccessoriesModel> Accessories { get; set; }
        public virtual DbSet<ColorModel> Colors { get; set; }
        public virtual DbSet<CurtainModel> Curtains { get; set; }
        public virtual DbSet<FabricModel> Fabrics { get; set; }
        public virtual DbSet<DecorationsModel> Decorations { get; set; }
        public virtual DbSet<MetaDataModel> MetaDatas { get; set; }
        public virtual DbSet<LambrequinsModel> Lambrequins { get; set; }
        public virtual DbSet<ConsistencyModel> Consistencies { get; set; }
        public virtual DbSet<ManufacturerModel> Manufacturers { get; set; }
        public virtual DbSet<BedspreadsModel> Bedspreads { get; set; }
        public virtual DbSet<PillowsModel> Pillows { get; set; }
        public virtual DbSet<MarketingInfoModel> MarketingInfos { get; set; }
        public virtual DbSet<ProductSetModel> Sets { get; set; }
        public virtual DbSet<MaterialModel> Materials { get; set; }
        public virtual DbSet<CurtainsTypeModel> CurtainsTypes { get; set; }
        public virtual DbSet<CurtainsKindModel> CurtainsKinds { get; set; }
        public virtual DbSet<FabricKindModel> FabricKinds { get; set; }
        public virtual DbSet<FabricTypeModel> FabricTypes { get; set; }
        public virtual DbSet<DesignModel> Designs { get; set; }
        public virtual DbSet<BracingModel> Bracings { get; set; }
        public virtual DbSet<OurWorksModel> OurWorks { get; set; }
        public virtual DbSet<ReviewModel> Reviews { get; set; }
        public virtual DbSet<ProductImageModel> ProductImages { get; set; }
        #endregion

        public CurtainsDbContext(DbContextOptions<CurtainsDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public bool HasActiveTransaction => _currentTransaction != null;

        public IDbContextTransaction GetCurrentTransaction() => _currentTransaction;

        public async Task<IDbContextTransaction> BeginTransaction()
        {
            if (_currentTransaction != null)
            {
                return null;
            }

            _currentTransaction = await Database.BeginTransactionAsync(IsolationLevel.ReadCommitted);

            return _currentTransaction;
        }

        public async Task CommitTransaction(IDbContextTransaction transaction)
        {
            if (transaction == null)
            {
                throw new ArgumentNullException(nameof(transaction));
            }

            if (transaction != _currentTransaction)
            {
                throw new InvalidOperationException($"Transaction {transaction.TransactionId} is not current");
            }

            try
            {
                await SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch
            {
                await RollbackTransaction();
                throw;
            }
            finally
            {
                _currentTransaction?.Dispose();
                _currentTransaction = null;
            }
        }

        public async Task RollbackTransaction()
        {
            try
            {
                await _currentTransaction.RollbackAsync();
            }
            finally
            {
                _currentTransaction?.Dispose();
                _currentTransaction = null;
            }
        }

    }
}