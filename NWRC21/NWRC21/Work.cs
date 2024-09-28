
namespace NWRC21
{
    public class Work
    {
        private string Service;
        private string reqTime;
        private string matCost; 
        public override string ToString()
        {
            return $"Service Name : {Service} ,Required Time : {reqTime},Material Cost : {matCost}";
        }

        public Work(string service, string reqTime, string matrCost)
        {
            this.Service = service;
            this.reqTime = reqTime;
            this.matCost = matrCost;
        }
        public string servicename()
        {
            return Service;
        }
        public string timeMin()
        {
            return reqTime;
        }
        public string matrCost()
        {
            return matCost;
        }
    }
}