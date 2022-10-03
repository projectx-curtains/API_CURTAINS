using Curtains.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain
{
    public static class EntityExtencions
    {
        private static long counter = DateTime.UtcNow.Ticks;

        public static Guid ToSequential(this Guid guid)
        {
            var guidBytes = guid.ToByteArray();
            var counterBytes = BitConverter.GetBytes(Interlocked.Increment(ref counter));

            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(counterBytes);
            }

            guidBytes[08] = counterBytes[1];
            guidBytes[09] = counterBytes[0];
            guidBytes[10] = counterBytes[7];
            guidBytes[11] = counterBytes[6];
            guidBytes[12] = counterBytes[5];
            guidBytes[13] = counterBytes[4];
            guidBytes[14] = counterBytes[3];
            guidBytes[15] = counterBytes[2];

            return new Guid(guidBytes);
        }

        public static T AsCreated<T>(this T entity) where T : Entity
        {
            var createdDate = DateTimeOffset.UtcNow;

            entity.Id = Guid.NewGuid().ToSequential();
            entity.CreatedDate = createdDate;
            entity.ModifiedDate = createdDate;
            entity.IsNew = true;

            return entity;
        }

        public static T AsUpdatedBy<T>(this T entity) where T : Entity
        {
            entity.ModifiedDate = DateTimeOffset.UtcNow;
            entity.IsModified = true;

            return entity;
        }
    }
}
