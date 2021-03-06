// <copyright file="Class1Test.cs">Copyright ©  2017</copyright>
using System;
using ClassLibrary1;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1.Tests
{
    /// <summary>Этот класс содержит параметризованные модульные тесты для Class1</summary>
    [PexClass(typeof(Class1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Class1Test
    {
        /// <summary>Тестовая заглушка для GetCows(Int32)</summary>
        [PexMethod]
        public string GetCowsTest([PexAssumeUnderTest]Class1 target, int n)
        {
            string result = target.GetCows(n);
            return result;
            // TODO: добавление проверочных утверждений в метод Class1Test.GetCowsTest(Class1, Int32)
        }
    }
}
