﻿using Library.Business.Interfaces;
using Library.DataAccess.Interfaces;
using Library.Entities.Concreate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Business.Concreate
{
    public class BookManager : GenericManager<Book>, IBookService
    {
        private readonly IBookDAL _bookDAL;
        public BookManager(IBookDAL bookDAL) : base(bookDAL)
        {
            _bookDAL = bookDAL;
        }

        public List<DualHelper> GetMostReadBook()
        {
            return _bookDAL.GetMostReadBook();
        }


        public async Task<Book> FindByNameAsync(string bookName)
        {
            return await _bookDAL.FindByNameAsync(bookName);
        }

        public async Task<List<Book>> GetBooksOfAuthorAsync(int authorId)
        {
            return await _bookDAL.GetBooksOfAuthorAsync(authorId);
        }

        public async Task<Book> GetBooksWithAllByIdAsync(int id)
        {
            return await _bookDAL.GetBooksWithAllByIdAsync(id);
        }

        public async Task<List<Book>> GetBooksWithAuthorsAsync()
        {
            return await _bookDAL.GetBooksWithAuthorsAsync();
        }

        public async Task<List<Book>> GetBooksWithBaseCategoryIdAsync(int id)
        {
            return await _bookDAL.GetBooksWithBaseCategoryIdAsync(id);
        }

        public async Task<List<Book>> GetBooksWithSubCategoryIdAsync(int id)
        {
            return await _bookDAL.GetBooksWithSubCategoryIdAsync(id);
        }

        public async Task<List<MemberBook>> GetBooksOfMemberWithAllAsync(int memberId)
        {
            return await _bookDAL.GetBooksOfMemberWithAllAsync(memberId);
        }      
       
        public async Task<MemberBook> GetMemberBookByBookIdAsync(int bookId)
        {
            return await _bookDAL.GetMemberBookByBookIdAsync(bookId);
        }

        

        public async Task<List<MemberBook>> GetReadBooksOfMemberAsync(int memberId)
        {
            return await _bookDAL.GetReadBooksOfMemberAsync(memberId);
        }

        

        public async Task AddMemberBookTableAsync(MemberBook memberBook)
        {
            await _bookDAL.AddMemberBookTableAsync(memberBook);
        }

        public async Task UpdateMemberBookTableAsync(MemberBook memberBook)
        {
            await _bookDAL.UpdateMemberBookTableAsync(memberBook);
        }

        public List<MemberBook> GetIndexPageBooks(out int toplamSayfa, string aranacakKelime, int aktifSayfa)
        {
            return _bookDAL.GetIndexPageBooks(out toplamSayfa, aranacakKelime, aktifSayfa);
        }

    }
}
