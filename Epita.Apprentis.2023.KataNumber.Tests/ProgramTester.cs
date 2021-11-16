﻿using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epita.Apprentis._2023.KataNumber.Tests
{
    [TestFixture]
    public class ProgramTester
    {
        [Test]
        public void When_User_Enter_A_Number_Then_The_Converter_Must_Be_Called()
        {
            IOAdapter adapter = Substitute.For<IOAdapter>();
            adapter.Read().Returns("42", "exit");

            IMorseConverter converter = Substitute.For<IMorseConverter>();
            converter.ToMorse(Arg.Any<int>()).Returns("Foo");

            var program = new Program(adapter, converter);

            program.Run();

            converter.Received(1).ToMorse(42);
            adapter.Received(1).Write("Foo");
        }
    }
}