using MelonLoader;
using UnityEngine;

namespace QuestCamera;

internal sealed class CameraControls
{
    private readonly PhysicalCamera camera;

    public CameraControls(
        PhysicalCamera camera)
    {
        this.camera = camera;
    }

    public void Freeze()
    {
        camera.Freeze();
    }

    public void Unfreeze()
    {
        camera.Unfreeze();
    }

    public void ToggleFreeze()
    {
        camera.ToggleFreeze();
    }

    public void Flip()
    {
        camera.Flip();
    }

    public void ZoomIn()
    {
        camera.ZoomIn();
    }

    public void ZoomOut()
    {
        camera.ZoomOut();
    }

    public void Photo()
    {
        MelonLogger.Msg(
            "QuestCamera: PHOTO requested.");

        // Screenshot system will be added next.
    }

    public void StartRecording()
    {
        MelonLogger.Msg(
            "QuestCamera: RECORD requested.");

        // Video recorder will be added next.
    }

    public void StopRecording()
    {
        MelonLogger.Msg(
            "QuestCamera: STOP RECORD requested.");

        // Video recorder will be added next.
    }
}
