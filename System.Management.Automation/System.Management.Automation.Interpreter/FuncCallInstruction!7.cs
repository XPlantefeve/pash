namespace System.Management.Automation.Interpreter
{
    using System;
    using System.Reflection;

    internal sealed class FuncCallInstruction<T0, T1, T2, T3, T4, T5, TRet> : CallInstruction
    {
        private readonly Func<T0, T1, T2, T3, T4, T5, TRet> _target;

        public FuncCallInstruction(Func<T0, T1, T2, T3, T4, T5, TRet> target)
        {
            this._target = target;
        }

        public FuncCallInstruction(MethodInfo target)
        {
            this._target = (Func<T0, T1, T2, T3, T4, T5, TRet>) Delegate.CreateDelegate(typeof(Func<T0, T1, T2, T3, T4, T5, TRet>), target);
        }

        public override object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5)
        {
            return this._target((arg0 != null) ? ((T0) arg0) : default(T0), (arg1 != null) ? ((T1) arg1) : default(T1), (arg2 != null) ? ((T2) arg2) : default(T2), (arg3 != null) ? ((T3) arg3) : default(T3), (arg4 != null) ? ((T4) arg4) : default(T4), (arg5 != null) ? ((T5) arg5) : default(T5));
        }

        public override int Run(InterpretedFrame frame)
        {
            frame.Data[frame.StackIndex - 6] = this._target((T0) frame.Data[frame.StackIndex - 6], (T1) frame.Data[frame.StackIndex - 5], (T2) frame.Data[frame.StackIndex - 4], (T3) frame.Data[frame.StackIndex - 3], (T4) frame.Data[frame.StackIndex - 2], (T5) frame.Data[frame.StackIndex - 1]);
            frame.StackIndex -= 5;
            return 1;
        }

        public override int ArgumentCount
        {
            get
            {
                return 6;
            }
        }

        public override MethodInfo Info
        {
            get
            {
                return this._target.Method;
            }
        }
    }
}

