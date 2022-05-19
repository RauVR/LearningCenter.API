using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Tls;

namespace LearningCenter.API.Shared.Extensions
{
    public static class ModelBuilderExtensions  //Le ponemos static
    {
        public static void UseSnakeCaseNamingConvention(this ModelBuilder builder)
        {
            foreach (var entity in builder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.GetTableName().ToSnakeCase());

                foreach (var property in entity.GetProperties())
                {
                    property.SetColumnName(property.GetColumnName().ToSnakeCase());
                }

                foreach (var key in entity.GetKeys())
                {
                    key.SetName(key.GetName().ToSnakeCase());
                }

                foreach (var foreignkey in entity.GetForeignKeys())
                {
                    foreignkey.SetConstraintName(foreignkey.GetConstraintName().ToSnakeCase());
                }

                foreach (var index in entity.GetIndexes())
                {
                    index.SetDatabaseName(index.GetDatabaseName().ToSnakeCase());
                }
                
            }
        }
    }
}