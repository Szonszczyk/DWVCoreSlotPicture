using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using System.Reflection;

namespace DWVCoreSlotPicture;


[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 2)]
public class LoadSlotImagesUsingWTTCommonLib(
    WTTServerCommonLib.WTTServerCommonLib? wttCommon
) : IOnLoad
{
    public async Task OnLoad()
    {
        if (wttCommon == null)
            return;

        var assembly = Assembly.GetExecutingAssembly();

        wttCommon.CustomSlotImageService.CreateSlotImages(assembly, Path.Join("db", "10_Slots"));

        await Task.CompletedTask;
    }
}