using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DonOfDesign.PracticeProxy.ControlsShow
{
    public class ProxyControlsCreator : ControlsCreator
    {
        private RealControlsCreator m_realCreator = new RealControlsCreator();
        private Thread m_thread;

        //定义事件;
        public event AddControlsHandler AddControlsEvent;
        
        public ProxyControlsCreator()
        {
            //将CreateEQPControls方法与真实对象的事件建立委托链
            m_realCreator.AddControlsEvent += new AddControlsHandler(CreateEQPControls);              
        }
        
        public override void CreateEQPControls()
        {
            if (m_realCreator.BeCompleted)
            {                
                m_controls = new Control[m_realCreator.Controls.Length];
                m_realCreator.Controls.CopyTo(m_controls, 0);

                //当代理对象的控件集合被更新后，需要触发事件通知OperatorForm
                if (AddControlsEvent != null)
                {
                    AddControlsEvent();
                }

                if (m_thread != null)
                {
                    m_thread.Abort();
                }
            }
            else
            {
                //在后台运行真实对象的业务逻辑;
                m_thread = new Thread(new ThreadStart(m_realCreator.CreateEQPControls));
                m_thread.Start();

                Thread.Sleep(200);
                
                //如果真实对象先于代理对象完成业务逻辑
                //作进一步的判断，以避免代理对象的执行结果覆盖真实对象的执行结果
                if (!m_realCreator.BeCompleted)
                {
                    //在前台运行代理对象的业务逻辑;
                    base.CreateEQPControls();
                }
            }
        }
    }
}
