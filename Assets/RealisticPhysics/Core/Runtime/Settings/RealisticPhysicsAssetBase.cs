namespace RealisticPhysics.Core.Settings
{
    using UnityEngine;

    public abstract class RealisticPhysicsAssetBase : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private string displayName;
        [SerializeField, TextArea] private string description;

        public string Id => id;
        public string DisplayName => string.IsNullOrWhiteSpace(displayName) ? name : displayName;
        public string Description => description;

        protected virtual void OnValidate()
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                id = System.Guid.NewGuid().ToString("N");
            }

            if (string.IsNullOrWhiteSpace(displayName))
            {
                displayName = name;
            }

            ValidateAsset();
        }

        protected virtual void ValidateAsset()
        {
        }

        public virtual void ResetToRecommendedDefaults()
        {
        }
    }
}
