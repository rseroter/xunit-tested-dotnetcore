using Xunit;
using tested_core_app.Controllers;

namespace unittests {

    public class TestClass {

        [Fact]
        public void Pass(){
            ValuesController vc = new ValuesController();
            Assert.Equal("pivotal", vc.Get(1));
        }

    }

}