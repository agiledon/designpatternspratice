using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace DonOfDesign.PracticeProxy.ControlsShow
{
    public class RealControlsCreator : ControlsCreator
    {
        //设置线程的休眠值，模拟数据库查询的耗费时间
        private const int SLEEPTIME = 200;

        private bool m_beCompleted = false;
        public bool BeCompleted
        {
            get { return m_beCompleted; }
        }

        //定义事件;
        public event AddControlsHandler AddControlsEvent;
        
        protected virtual void OnCreateCompleted()
        {
            //如果事件被订阅了，就通知观察者角色；
            if (AddControlsEvent != null)
            {                
                AddControlsEvent();
            }
        }

        public override void CreateEQPControls()
        {
            base.CreateEQPControls();

            //查询数据库，修改控件对象的属性；
            //不返回m_controls，而是直接将值放到Controls属性中;

            //为简便起见，我直接创建一些Button控件
            //创建10个Button控件
            //为模仿数据库查询的耗时，引入线程休眠
            //为区分控件的状态，将原有控件的BackColor修改为红色
            foreach (Control btn in base.m_controls)
            {
                btn.BackColor = Color.Red;
                Thread.Sleep(SLEEPTIME);
            }

            m_beCompleted = true;
            OnCreateCompleted();
        }
    }

}
