﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancistoCloneWeb.Models.Maps
{
    public class TipoRutinaMap : IEntityTypeConfiguration<TipoRutina>
    {
        public void Configure(EntityTypeBuilder<TipoRutina> builder)
        {
            builder.ToTable("TipoRutina");
            builder.HasKey(o => o.Id);
        }
    }
}
