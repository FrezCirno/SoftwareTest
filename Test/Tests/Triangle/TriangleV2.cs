using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProgramTest.Tests.Triangle
{
    public class TriangleV2:Triangle
    {
        protected override string CheckTriangle(TriangleType triangle)
        {
            var result = new Dictionary<string, bool>();
            result.Add("等腰", false);
            result.Add("等边", false);
        
            //边长信息有误。
            if (!CheckInput(triangle.Side1, triangle.Side2, triangle.Side3)) return "您输入的边长信息有误！";
            var edge1 = float.Parse(triangle.Side1);
            var edge2 = float.Parse(triangle.Side2);
            var edge3 = float.Parse(triangle.Side3);
            
            //构不成三角形。
            if (!CheckTriangle(edge1, edge2, edge3)) return "您输入的三边构不成三角形！";
            //三角形
            result["等边"] = CheckEquicrural(edge1, edge2, edge3);
            result["等腰"] = CheckEquilateral(edge1, edge2, edge3);
            string resultTip = (result["等腰"] && !result["等边"]) ? "等腰" : "";
            resultTip += result["等边"] ? "等边" : "";
            resultTip += (!result["等腰"] && !result["等边"]) ? "普通" : "";
            resultTip += "三角形";
            return resultTip;
        }

        private static bool CheckEquicrural(float e1, float e2, float e3)
        {
            return e1 == e2 && e2 == e3;
        }

        private static bool CheckEquilateral(float e1, float e2, float e3)
        {
            return e1 == e2 || e2 == e3 || e3 == e1;
        }

        private static bool CheckTriangle(float edge1, float edge2, float edge3)
        {
            float[] edges = { edge1, edge2, edge3 };
            var sum = edges[0] + edges[1] + edges[2];
            int successFlag = 0;
            for (int i = 0; i < edges.Count(); i++)
            {
                if (edges[i] < sum - edges[i])
                {
                    successFlag++;
                }
            }
            return successFlag == 3;
        }

        private static bool CheckInput(string edge1, string edge2, string edge3)
        {
            try
            {
                var e1 = float.Parse(edge1);
                var e2 = float.Parse(edge2);
                var e3 = float.Parse(edge3);
                if (e1 > 0 && e2 > 0 && e3 > 0 && e1 <= 100 && e2 <= 100 && e3 <= 100)
                {
                    return true;
                }
            }
            catch
            {
                // ignored
            }

            return false;
        }
    }
}
