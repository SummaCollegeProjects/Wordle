using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Wordle.Data;
using System;
using System.Linq;
using Wordle.Models;

namespace Wordle.Models
{
    public class WordleWords
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WordleContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WordleContext>>()))
            {
                // Look for any words.
                if (context.Word.Any())
                {
                    return;
                }
                context.Word.AddRange(
                    new Word
                    {
                        Letters = "appel",
                        Length = 5,
                        Created = DateTime.Parse("2024-01-01")
                    },
                    new Word
                    {
                        Letters = "druif",
                        Length = 5,
                        Created = DateTime.Parse("2024-01-02")
                    },
                    new Word
                    {
                        Letters = "peren",
                        Length = 5,
                        Created = DateTime.Parse("2024-01-03")
                    },
                    new Word
                    {
                        Letters = "vader",
                        Length = 5,
                        Created = DateTime.Parse("2024-01-04")
                    },
                    new Word
                    {
                        Letters = "cavia",
                        Length = 5,
                        Created = DateTime.Parse("2024-01-05")
                    },
                    new Word
                    {
                        Letters = "fiets",
                        Length = 5,
                        Created = DateTime.Parse("2024-01-06")
                    },
                    new Word
                    {
                        Letters = "stoel",
                        Length = 5,
                        Created = DateTime.Parse("2024-01-07")
                    },
                    new Word
                    {
                        Letters = "tafel",
                        Length = 5,
                        Created = DateTime.Parse("2024-01-08")
                    },
                    new Word
                    {
                        Letters = "beker",
                        Length = 5,
                        Created = DateTime.Parse("2024-01-09")
                    },
                    new Word
                    {
                        Letters = "broek",
                        Length = 5,
                        Created = DateTime.Parse("2024-01-10")
                    }


                );
                context.SaveChanges();
            }
        }
    }
}
