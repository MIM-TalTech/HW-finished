using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW4.Tests {

    public abstract class AbstractClassTests<TClass, TBaseClass>: BaseClassTests<TClass, TBaseClass>
    {

        [TestMethod]
        public void IsAbstract()
        {
            Assert.IsTrue(type.IsAbstract);
        }


    }

}