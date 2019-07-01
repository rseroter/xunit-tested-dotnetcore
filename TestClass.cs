using Xunit;
using tested_core_app.Controllers;

namespace unittests {

    public class TestClass {

        private ValuesController _vc;

        public TestClass() {
            _vc = new ValuesController();
        }

        [Fact]
        public void Test1(){
            Assert.Equal("pivotal", _vc.Get(1));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(9)]
        //[InlineData(20)]
        public void Test2(int value) {
            Assert.Equal("public", _vc.GetPublicStatus(value));
        }

    }

}
