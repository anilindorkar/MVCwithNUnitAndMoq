using Moq;
using MVCwithNUnitAndMoq.ModelAccess;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCwithNUnitAndMoq.Test
{
    [TestFixture]
    public class CheckDepartmentTest
    {
        [Test]
        public void CheckDepartmentExist() {
            var obj = new DepartmentAccess();
            var Res = obj.CheckDeptExist(10);
            Assert.That(Res, Is.True);
        }

        [Test]
        public void CheckDepartmentExistWithMoq() {
            //Create a Fake Object
            var fakeobject = new Mock<IDepartmentAccess>();
            // Set the Mock Configuration
            //Th eCheckDeptExist() method is call is set with the Integer Parameter type.
            // The Configuration also defines the Return type from the method.

            fakeobject.Setup(x => x.CheckDeptExist(It.IsAny<int>())).Returns(true);

            //Call the method.
            var Res = fakeobject.Object.CheckDeptExist(10);

            Assert.That(Res, Is.True);
        }
    }

    
}
