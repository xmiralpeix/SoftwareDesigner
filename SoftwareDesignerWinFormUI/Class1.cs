namespace Repository
{
    public interface IXMRRepository: System.IDisposable, System.Collections.Generic.IEnumerable<oDataInfo>
    {
        void Clear();

        bool Add(IResultMsg ResultMsg, oNewData oData);
        
        void Load(oDataFilter oFilter);
        
    }

    public class oDataInfo { }
    public class oNewData { }
    public class IResultMsg { }
    public class oDataFilter { }
}
