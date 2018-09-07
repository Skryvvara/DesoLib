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
        public bool IsTrial { set; get; }
        public bool HardmodeDone { set; get; }
        public bool SpeedrunDone { set; get; }
        public bool NodeathDone { set; get; }
        public bool IsComplete { set; get; }

        public Dungeon() { }

        public Dungeon(string dungeonName, 
                        string achievementOneName, int achievementOneValue, int achievementOneMax,
                        string achievementTwoName, int achievementTwoValue, int achievementTwoMax,
                        bool isTrial = false, bool hardmodeDone = false, bool speedrunDone = false, bool nodeathDone = false, bool isComplete = false)
        {
            this.DungeonName = dungeonName;

            this.AchievementOneName = achievementOneName;
            this.AchievementOneValue = achievementOneValue;
            this.AchievementOneMax = achievementOneMax;
            this.AchievementTwoName = achievementTwoName;
            this.AchievementTwoValue = achievementTwoValue;
            this.AchievementTwoMax = achievementTwoMax;
            this.IsTrial = isTrial;
            this.HardmodeDone = hardmodeDone;
            this.SpeedrunDone = speedrunDone;
            this.NodeathDone = nodeathDone;
            this.IsComplete = isComplete;
        }

        public void CheckCompletion()
        {
            if (this.AchievementOneValue == this.AchievementOneMax && this.AchievementTwoValue == this.AchievementTwoMax || this.IsTrial)
            {
                if (this.HardmodeDone && this.SpeedrunDone && this.NodeathDone)
                {
                    this.IsComplete = true;
                }
                else
                {
                    this.IsComplete = false;
                }
            }
            else
            {
                this.IsComplete = false;
            }
        }
    }
}
