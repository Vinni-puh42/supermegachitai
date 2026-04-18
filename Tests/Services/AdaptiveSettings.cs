using AdaptiveAlgebraTest.Enums;

namespace AdaptiveAlgebraTest.Services
{
    class AdaptiveSettings
    {
        public bool SimplifyEverything { get; set; }
        public bool EmphasizeTopic { get; set; }
        public bool Reinforcement { get; set; }
        public bool ReinforcementRare { get; set; }
        public bool ForceTheory { get; set; }
        public bool HardStepByStep { get; set; }
        public bool FrequentRevision { get; set; }

        public Difficulty EasyDifficulty { get; set; }
        public Difficulty MediumDifficulty { get; set; }
        public Difficulty HardDifficulty { get; set; }
    }
}