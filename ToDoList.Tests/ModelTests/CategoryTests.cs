using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTest : IDisposable
  {
    public void Dispose()
    {
      Category.ClearAll();
    }

    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
    {
      Category newCategory = new Category("test category");
      Assert.AreEqual(typeof(Category), newCategory.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Category";
      Category newCategory = new Category(name);

      //Act
      string result = newCategory.GetName();

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      //Arrange
      string name = "Test Category";
      Category newCategory = new Category(name);

      //Act
      int result = newCategory.GetId();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllCategoryObjects_CategoryList()
    {
      // Arrange
      string name1 = "work";
      string name2 = "play";
      Category newCategory1 = new Category(name1);
      Category newCategory2 = new Category(name2);
      List<Category> newList = new List<Category> { newCategory1, newCategory2 };

      // Act
      List<Category> result = Category.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectCategory_Category()
    {
      //Arrange
      string name1 = "work";
      string name2 = "play";
      Category newCategory1 = new Category(name1);
      Category newCategory2 = new Category(name2);

      //Act
      Category result = Category.Find(2);

      //Assert
      Assert.AreEqual(newCategory2, result);
    }
    [TestMethod]
    public void GetItems_ReturnsEmptyList_ItemList()
    {
      //Arrange
      string name = "work";
      Category newCategory = new Category(name);
      List<Item> newList = new List<Item> { };

      //Act
      List<Item> result = newCategory.GetItems();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void AddItem_AssociatesItemWithCategory_ItemList()
    {
      //Arrange
      string description = "wash ass";
      Item newItem = new Item(description);
      List<Item> newList = new List<Item> { newItem };
      string name = "work";
      Category newCategory = new Category(name);
      newCategory.AddItem(newItem);

      //Act
      List<Item> result = newCategory.GetItems();

      //Assert
      CollectionAssert.AreEqual(newList, result);

    }

  }
}

//Arrange

//Act

//Assert
