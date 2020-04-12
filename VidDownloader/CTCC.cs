public class CTCC
{
    public static void CrossThreadControlCall(System.Windows.Forms.Control control, System.Windows.Forms.MethodInvoker method)
    {
        if (control.InvokeRequired)
            control.Invoke(method);
        else
            method.Invoke();
    }
}
