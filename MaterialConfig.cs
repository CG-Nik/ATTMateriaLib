namespace MateriaLib
{
    public class MaterialConfig
    {
        public float? SourceThermalConductivity { get; set; }
        public float? RecieveThermalConductivity { get; set; }
        public float? InternalThermalConductivity { get; set; }
        public float? GlowingStart { get; set; }
        public float? GlowingEnd { get; set;}
        public float? ForgeMultiplier { get; set; }
        public float? MeltingPoint { get; set; }
        public float? MaxTemperatureForParticles { get; set; }
        public float? NailHealthMultiplier { get; set; }
        public float? MaxCraftingDamageMultiplier { get; set; }
        public float? DamageMultiplier { get; set; }
        public float? DurabilityMultiplier { get; set; }
        public float? Density {  get; set; }
        public float? WeightMultiplier { get; set; }
        public float? TightnessMultiplier { get; set; }
        public float? TightnessBowImpact { get; set; }
        public float? MinimumProjectileWeight { get; set; }
        public float? MaxInvalidProjectileVelocityMultiplier { get; set; }
        public float? NoiseMultiplier { get; set; }
        public uint? HardnessLevel { get; set; }
    }
}
