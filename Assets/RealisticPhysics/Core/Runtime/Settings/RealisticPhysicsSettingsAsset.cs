namespace RealisticPhysics.Core.Settings
{
    public abstract class RealisticPhysicsSettingsAsset : RealisticPhysicsAssetBase
    {
        public abstract string ModuleId { get; }

        public virtual void EnsureDefaults()
        {
        }
    }
}
