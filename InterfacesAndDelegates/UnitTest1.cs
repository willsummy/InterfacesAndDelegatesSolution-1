using System.Collections.Generic;
using Xunit;

namespace InterfacesAndDelegates
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var earl = new Employee();
            var vicki = new Retiree();
            var steve = new Contractor();
            var ibm = new MainFrame();

            var team = new List<IProvideCompensationInformation>
            {
                earl, vicki, steve

            };
           

            var utils = new HrUtils();


            var report = utils.GetTotalCompensationFor(team);

      
        }
    }
}