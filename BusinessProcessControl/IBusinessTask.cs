namespace BusinessProcessControl
{
    public interface IBusinessTask
    {
        event OnReportMessage ReportMessage;

        void Run();
        void AddTask(ITask processFile);
    }
}