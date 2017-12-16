namespace CurApi.Migrations
{
    using CurApi.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CurApi.Models.CurApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CurApi.Models.CurApiContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.ProFaCurdef.AddOrUpdate(
              p => p.CurCd,
              new ProFaCurdef
              {
                  CurCd = "INR",
                  CurDesc = "INR",
                  CurDispNm = "INDIAN RUPEE",
                  CurSecCur = "PAISE",
                  CurRowid = System.Guid.NewGuid(),
                  CurCreatedBy = "INSTALL",
                  CurCreatedDt = DateTime.Now,
                  CurModifiedBy = "INSTALL",
                  CurModifiedDt = DateTime.Now,
                  CurDelFlg = "NULL",
                  CurDelId = 0
              },
               new ProFaCurdef
              {
                  CurCd = "DKK",
                  CurDesc = "DKK",
                  CurDispNm = "DANISH KRONE",
                  CurSecCur = "RE",
                  CurRowid = System.Guid.NewGuid(),
                  CurCreatedBy = "INSTALL",
                  CurCreatedDt = DateTime.Now,
                  CurModifiedBy = "INSTALL",
                  CurModifiedDt = DateTime.Now,
                  CurDelFlg = "NULL",
                  CurDelId = 0
              },

               new ProFaCurdef
              {
                  CurCd = "EUR",
                  CurDesc = "EUR",
                  CurDispNm = "EURO",
                  CurSecCur = "CENT",
                  CurRowid = System.Guid.NewGuid(),
                  CurCreatedBy = "INSTALL",
                  CurCreatedDt = DateTime.Now,
                  CurModifiedBy = "INSTALL",
                  CurModifiedDt = DateTime.Now,
                  CurDelFlg = "NULL",
                  CurDelId = 0
              },
 new ProFaCurdef
              {
                  CurCd = "MYR",
                  CurDesc = "MYR",
                  CurDispNm = "MALAYSIAN RINGGIT",
                  CurSecCur = "SEN",
                  CurRowid = System.Guid.NewGuid(),
                  CurCreatedBy = "INSTALL",
                  CurCreatedDt = DateTime.Now,
                  CurModifiedBy = "INSTALL",
                  CurModifiedDt = DateTime.Now,
                  CurDelFlg = "NULL",
                  CurDelId = 0
              },
 new ProFaCurdef
              {
                  CurCd = "MUR",
                  CurDesc = "MUR",
                  CurDispNm = "MAURITIAN RUPEE",
                  CurSecCur = "CENT",
                  CurRowid = System.Guid.NewGuid(),
                  CurCreatedBy = "INSTALL",
                  CurCreatedDt = DateTime.Now,
                  CurModifiedBy = "INSTALL",
                  CurModifiedDt = DateTime.Now,
                  CurDelFlg = "NULL",
                  CurDelId = 0
              },
 new ProFaCurdef
              {
                  CurCd = "PLN",
                  CurDesc = "PLN",
                  CurDispNm = "POLISH ZLOTY",
                  CurSecCur = "GROSZ",
                  CurRowid = System.Guid.NewGuid(),
                  CurCreatedBy = "INSTALL",
                  CurCreatedDt = DateTime.Now,
                  CurModifiedBy = "INSTALL",
                  CurModifiedDt = DateTime.Now,
                  CurDelFlg = "NULL",
                  CurDelId = 0
              },
 new ProFaCurdef
              {
                  CurCd = "GBP",
                  CurDesc = "GBP",
                  CurDispNm = "POUND STERLING",
                  CurSecCur = "PENNY",
                  CurRowid = System.Guid.NewGuid(),
                  CurCreatedBy = "INSTALL",
                  CurCreatedDt = DateTime.Now,
                  CurModifiedBy = "INSTALL",
                  CurModifiedDt = DateTime.Now,
                  CurDelFlg = "NULL",
                  CurDelId = 0
              },
 new ProFaCurdef
              {
                  CurCd = "RUB",
                  CurDesc = "RUB",
                  CurDispNm = "RUSSIAN RUBLE",
                  CurSecCur = "KOPEYKA",
                  CurRowid = System.Guid.NewGuid(),
                  CurCreatedBy = "INSTALL",
                  CurCreatedDt = DateTime.Now,
                  CurModifiedBy = "INSTALL",
                  CurModifiedDt = DateTime.Now,
                  CurDelFlg = "NULL",
                  CurDelId = 0
              },
 new ProFaCurdef
              {
                  CurCd = "SGD",
                  CurDesc = "SGD",
                  CurDispNm = "SINGAPORE DOLLAR",
                  CurSecCur = "CENT",
                  CurRowid = System.Guid.NewGuid(),
                  CurCreatedBy = "INSTALL",
                  CurCreatedDt = DateTime.Now,
                  CurModifiedBy = "INSTALL",
                  CurModifiedDt = DateTime.Now,
                  CurDelFlg = "NULL",
                  CurDelId = 0
              },
 new ProFaCurdef
              {
                  CurCd = "THB",
                  CurDesc = "THB",
                  CurDispNm = "THAI BAHT",
                  CurSecCur = "SATANG",
                  CurRowid = System.Guid.NewGuid(),
                  CurCreatedBy = "INSTALL",
                  CurCreatedDt = DateTime.Now,
                  CurModifiedBy = "INSTALL",
                  CurModifiedDt = DateTime.Now,
                  CurDelFlg = "NULL",
                  CurDelId = 0
              },
 new ProFaCurdef
              {
                  CurCd = "UAH",
                  CurDesc = "UAH",
                  CurDispNm = "Ukrainian Hryvnia",
                  CurSecCur = "KOPIYKA",
                  CurRowid = System.Guid.NewGuid(),
                  CurCreatedBy = "INSTALL",
                  CurCreatedDt = DateTime.Now,
                  CurModifiedBy = "INSTALL",
                  CurModifiedDt = DateTime.Now,
                  CurDelFlg = "NULL",
                  CurDelId = 0
              },
 new ProFaCurdef
              {
                  CurCd = "USD",
                  CurDesc = "USD",
                  CurDispNm = "US DOLLAR",
                  CurSecCur = "CENT",
                  CurRowid = System.Guid.NewGuid(),
                  CurCreatedBy = "INSTALL",
                  CurCreatedDt = DateTime.Now,
                  CurModifiedBy = "INSTALL",
                  CurModifiedDt = DateTime.Now,
                  CurDelFlg = "NULL",
                  CurDelId = 0
              }

                //new ProFaCurdef { FullName = "Brice Lambson" },
                //new ProFaCurdef { FullName = "Rowan Miller" }
            );
            context.SaveChanges();
        }
    }
}
