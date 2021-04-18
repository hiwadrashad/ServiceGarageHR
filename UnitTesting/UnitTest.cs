using NUnit.Framework;

namespace UnitTesting
{
    public class UnitTest
    {
        Logic.DelegateLogic.DelegateMethods methods = new Logic.DelegateLogic.DelegateMethods();
        [Test]
        [Category("DelegateMethods")]
        public void Spanning()
        {
            NUnit.Framework.Assert.DoesNotThrow(methods.AddBandenSpanning);
        }
        [Test]
        [Category("DelegateMethods")]
        public void Olie()
        {
            NUnit.Framework.Assert.DoesNotThrow(methods.AddOlie);
        }
        [Test]
        [Category("DelegateMethods")]
        public void Lichten()
        {
            NUnit.Framework.Assert.DoesNotThrow(methods.AddLichten);
        }
        [Test]
        [Category("DelegateMethods")]
        public void Computer()
        {
            NUnit.Framework.Assert.DoesNotThrow(methods.AddComputer);
        }
        [Test]
        [Category("DelegateMethods")]
        public void Accu()
        {
            NUnit.Framework.Assert.DoesNotThrow(methods.AddAccu);
        }
        [Test]
        [Category("DelegateMethods")]
        public void Motor()
        {
            NUnit.Framework.Assert.DoesNotThrow(methods.AddMotor);
        }
        [Test]
        [Category("DelegateMethods")]
        public void ExtraWassen()
        {
            NUnit.Framework.Assert.DoesNotThrow(methods.AddExtraWassen);
        }
        [Test]
        [Category("DelegateMethods")]
        public void ExtraSchoonmaken()
        {
            NUnit.Framework.Assert.DoesNotThrow(methods.AddExtraSchoonmaken);
        }
        [Test]
        [Category("DelegateMethods")]
        public void ExtraWinterbanden()
        {
            NUnit.Framework.Assert.DoesNotThrow(methods.AddExtraWinterBanden);
        }
    }
}