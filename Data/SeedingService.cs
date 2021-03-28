using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public  void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //DB has been Seeded
            }

            //Criando departamentos
            Department d1 = new Department(1, "Computadores");
            Department d2 = new Department(2, "Eletronicos");
            Department d3 = new Department(3, "Roupas");
            Department d4 = new Department(4, "Livros");

            //Criando vendedores
            Seller s1 = new Seller(1, "Andre Freitas", "andre@gmail.com", new DateTime(1974, 4, 4), 7000.0, d1);
            Seller s2 = new Seller(2, "Matheus Freitas", "matheus@gmail.com", new DateTime(2006, 8, 8), 6000.0, d1);
            Seller s3 = new Seller(3, "Ale Freitas", "ale@gmail.com", new DateTime(1971, 4, 4), 4000.0, d2);
            Seller s4 = new Seller(4, "Lucas Freitas", "luc@gmail.com", new DateTime(1990, 8, 8), 3000.0, d2);
            Seller s5 = new Seller(5, "Ale Freitas", "ale@gmail.com", new DateTime(1971, 4, 4), 4000.0, d2);
            Seller s6 = new Seller(6, "Lucas Freitas", "leo@gmail.com", new DateTime(1997, 8, 8), 2000.0, d3);
            
            //Criando vendas
            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 26), 15000.0, SaleStatus.Billed, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 25), 19000.0, SaleStatus.Billed, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 27), 5000.0, SaleStatus.Billed, s2);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 25), 1030.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 29), 7000.0, SaleStatus.Billed, s4);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 20), 19000.0, SaleStatus.Billed, s5);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 27), 5000.0, SaleStatus.Billed, s6);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 09, 25), 1200.0, SaleStatus.Billed, s1);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 09, 29), 4500.0, SaleStatus.Billed, s2);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10);

            _context.SaveChanges();

        }
    }
}
