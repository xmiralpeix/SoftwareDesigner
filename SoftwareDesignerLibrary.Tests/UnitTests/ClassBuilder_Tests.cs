using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Autofac;


namespace SoftwareDesignerLibrary.Tests.UnitTests
{
    public class ClassBuilder_Tests
    {

        [Fact]
        public void BuildFile_NullClassInfo_CannotBuildFile()
        {

            bool expected = false;

            string validationResult = "";
            ClassBuilder builder = new SoftwareDesignerLibrary.ClassBuilder();
            builder.CodeBuilder = new CSharpCodeBuilder();

            bool actual = builder.CanBuildFile(validationResult);

            Assert.True(actual == expected);

        }

        [Fact]
        public void BuildFile_EmptyClassInfo_CannotBuildFile()
        {

            bool expected = false;

            string validationResult = "";
            ClassInfo oClassInfo = new SoftwareDesignerLibrary.ClassInfo();
            ClassBuilder builder = new SoftwareDesignerLibrary.ClassBuilder();
            builder.CodeBuilder = new CSharpCodeBuilder();
            builder.oClassInfo = oClassInfo;

            bool actual = builder.CanBuildFile(validationResult);

            Assert.True(actual == expected);

        }

        [Fact]
        public void BuildFile_FillClassName_CanBuildFile()
        {

            bool expected = true;

            string validationResult = "";
            ClassInfo oClassInfo = new SoftwareDesignerLibrary.ClassInfo();
            oClassInfo.ClassName = nameof(BuildFile_FillClassName_CanBuildFile);
            ClassBuilder builder = new SoftwareDesignerLibrary.ClassBuilder();
            builder.CodeBuilder = new CSharpCodeBuilder();
            builder.oClassInfo = oClassInfo;

            bool actual = builder.CanBuildFile(validationResult);

            Assert.True(actual == expected);

        }

    }
}
