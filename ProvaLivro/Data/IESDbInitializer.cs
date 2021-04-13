using Microsoft.EntityFrameworkCore;
using ProvaLivro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaLivro.Data
{
    public class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {
            context.Database.EnsureCreated();

            if (context.Livros.Any())
            {
                return;
            }

            context.SaveChanges();
        }
    }
}
