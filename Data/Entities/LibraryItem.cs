using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Data
{
    public class LibraryItem : BaseEntity
    {
        [Required]
        public virtual string Title { get; set; }
        public virtual string Author { get; set; }
        public virtual Nullable<int> Pages { get; set; }
        public virtual Nullable<int> RunTimeMinutes { get; set; }
        [Required]
        public virtual bool IsBorrowable { get; set; }
        public virtual string Borrower { get; set; }
        public virtual Nullable<DateTime> BorrowDate { get; set; }

        // i would have prefered a enum here instead.
        [Required]
        public virtual string Type { get; set; }
       
        [ForeignKey("Id")]
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public LibraryItem() { }
        
        public LibraryItem(LibraryItem item)
        {
            Title = item.Title;
            Type = "Book";

            switch (item.Type.ToUpper())
            {
                case "BOOK":
                    Author = item.Author;
                    Pages = item.Pages;
                    Borrower = item.Borrower;
                    IsBorrowable = true;
                    BorrowDate = item.BorrowDate;
                    break;

                case "DVD":
                    RunTimeMinutes = item.RunTimeMinutes;
                    Borrower = item.Borrower;
                    IsBorrowable = true;
                    BorrowDate = item.BorrowDate;
                    break;

                case "AUDIOBOOK":
                    Author = item.Author;
                    RunTimeMinutes = item.RunTimeMinutes;
                    Borrower = item.Borrower;
                    IsBorrowable = true;
                    BorrowDate = item.BorrowDate;
                    break;

                case "REFERENCEBOOK":
                    Author = item.Author;
                    Pages = item.Pages;
                    IsBorrowable = false;
                    break;
                default:
                    break;
            }
        }

        
        }

    }

