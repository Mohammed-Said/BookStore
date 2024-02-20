﻿using BookStore.Models;

namespace BookStore.Application.Services
{
  public interface ICategoryService
  {
    bool AddCategory(Category Category);
    bool UpdateCategory(Category Category);
    bool DeleteCartItem(int categoryId);
    Category GetbyId(int id);
    List<Category> GetAllCategories();
        void DeleteCategory(int id);
    }
}