﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Curtains.Domain.Models;

namespace Curtains.Domain.Data
{
    internal class OrderCurtainMapping : IEntityTypeConfiguration<OrderCurtainModel>
    {
        public void Configure(EntityTypeBuilder<OrderCurtainModel> builder)
        {
            builder.HasOne(d => d.Curtains)
                 .WithMany(p => p.OrderCurtains)
                 .HasForeignKey(d => d.CurtainsId)
                 .HasConstraintName("FK_OrderCurtains_Curtains");

            builder.HasOne(d => d.Order)
                .WithMany(p => p.OrderCurtains)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OrderCurtains_Order");
        }
    }
}