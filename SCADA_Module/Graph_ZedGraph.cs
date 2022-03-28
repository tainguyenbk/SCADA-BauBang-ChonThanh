using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;
using System.Drawing;
using PLC_Config;

namespace SCADA_Module
{
    public class Graph_ZedGraph
    {

        SCADA Parent;
        System.Timers.Timer UpdateTimer;
        int tickstart = 0;
        ZedGraphControl graph;
        string taggg;
        string taskkk;
        public Graph_ZedGraph(SCADA parent,ZedGraphControl Graph,string title,string xtitle,string ytitle,int point,string curve_label,double XscaleMin, double XscaleMax, double Xminorstep, double Xmajorstep, string task, string tag)
        {
            Parent = parent;
            taggg = tag;
            taskkk = task;
            UpdateTimer = new System.Timers.Timer();
            UpdateTimer.Interval = 50;
            UpdateTimer.Elapsed += UpdateTimer_Elapsed;
            UpdateTimer.AutoReset = true;
            UpdateTimer.Start();
            graph = Graph;

            GraphPane pane = graph.GraphPane;
            pane.Title.Text = title;
            pane.XAxis.Title.Text = xtitle;
            pane.YAxis.Title.Text = ytitle;
            RollingPointPairList list = new RollingPointPairList(point);
            LineItem curve = pane.AddCurve(curve_label, list, Color.Blue, SymbolType.None);
            pane.XAxis.Scale.Min = XscaleMin;
            pane.XAxis.Scale.Max = XscaleMax;
            pane.XAxis.Scale.MinorStep = Xminorstep;
            pane.XAxis.Scale.MajorStep = Xmajorstep;

            graph.AxisChange();

            tickstart = Environment.TickCount;
        }

        double value;
        private void UpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            ///value = 1;

            TASK task = Parent.FindTask(taskkk);
            if(task != null)
            {
                TAG tag = task.FindTag(taggg);
                if (tag != null)
                {
                    value = Convert.ToDouble(tag.Value);
                }
            }
            if(graph.GraphPane!= null)
            {
                if (graph.GraphPane.CurveList.Count <= 0)
                    return;
            }
            LineItem curve = graph.GraphPane.CurveList[0] as LineItem;
            IPointListEdit list = curve.Points as IPointListEdit;
            if (list == null)
                return;
            double time = (Environment.TickCount - tickstart) / 1000;
            list.Add(time, value);
            Scale xScale = graph.GraphPane.XAxis.Scale;
            if(time > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = time + xScale.MajorStep;
                xScale.Min = xScale.Max - 30.0;
            }
            graph.AxisChange();
            graph.Invalidate();
        }
    }
}
