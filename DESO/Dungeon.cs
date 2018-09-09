using System.Collections.Generic;

namespace DESO
{
    [System.Serializable]
    public class Dungeon
    {
        public string DungeonName { get; set; }
        public string AchievementOneName { set; get; }
        public int AchievementOneValue { set; get; }
        public int AchievementOneMax { set; get; }
        public string AchievementTwoName { set; get; }
        public int AchievementTwoValue { set; get; }
        public int AchievementTwoMax { set; get; }
        public List<Set> Sets { set; get; }
        public bool IsTrial { set; get; }
        public bool HardmodeDone { set; get; }
        public bool SpeedrunDone { set; get; }
        public bool NodeathDone { set; get; }
        public bool DoneOnVet { set; get; }
        public bool IsComplete { set; get; }
        public bool HasHardmode { set; get; }
        public bool HasSpeedrun { set; get; }
        public bool HasNoDeath { set; get; }

        public Dungeon() { }

        public Dungeon(string dungeonName,
                        string achievementOneName, int achievementOneValue, int achievementOneMax,
                        string achievementTwoName, int achievementTwoValue, int achievementTwoMax,
                        List<Set> sets, bool isTrial = false,
                        bool hasHardmode = true, bool hasNoDeath = true, bool hasSpeedrun = true,
                        bool hardmodeDone = false, bool speedrunDone = false, bool nodeathDone = false, 
                        bool doneOnVet = false, bool isComplete = false)
        {
            this.DungeonName = dungeonName;

            this.AchievementOneName = achievementOneName;
            this.AchievementOneValue = achievementOneValue;
            this.AchievementOneMax = achievementOneMax;
            this.AchievementTwoName = achievementTwoName;
            this.AchievementTwoValue = achievementTwoValue;
            this.AchievementTwoMax = achievementTwoMax;
            this.Sets = sets;
            this.IsTrial = isTrial;
            this.HasHardmode = hasHardmode;
            this.HasSpeedrun = hasSpeedrun;
            this.HasNoDeath = hasNoDeath;
            this.HardmodeDone = hardmodeDone;
            this.SpeedrunDone = speedrunDone;
            this.NodeathDone = nodeathDone;
            this.DoneOnVet = doneOnVet;
            this.IsComplete = isComplete;
        }

        public void CheckCompletion()
        {


            if (this.AchievementOneValue == this.AchievementOneMax && this.AchievementTwoValue == this.AchievementTwoMax || this.IsTrial)
                this.IsComplete = (this.DoneOnVet && this.HardmodeDone == this.HasHardmode 
                                    && this.SpeedrunDone == this.HasSpeedrun && this.NodeathDone == this.HasNoDeath);
            else
                this.IsComplete = false;
        }
    }

    [System.Serializable]
    public class Set
    {
        public string SetName { set; get; }
        public string SetURL { set; get; }

        public Set() { }

        public Set(string setName, string setURL)
        {
            this.SetName = setName;
            this.SetURL = setURL;
        }
    }
}