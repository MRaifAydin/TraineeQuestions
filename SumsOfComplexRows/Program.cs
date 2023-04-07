// Calculate each schools classroom count for the given floor. Assign them to a dto. In the end, we should know each school's, each floor's classroom count.

List<Result> Calculate(List<Entity> data)
{
    return null;

}

var testData = new List<Entity>
{
    new Entity
    {
        SchoolName = "Haldun Taner İlkokulu",
        ClassroomsByFloor = new List<EntityRow>
        {
            new EntityRow
            {
                FloorNumber = 1,
                ClassroomNames = new List<string>
                {
                    "a",
                    "s",
                    "d",
                    "f",
                    "z",
                    "x",
                    "c",
                    "v",
                    "q",
                    "w",
                }
            },
            new EntityRow
            {
                FloorNumber = 2,
                ClassroomNames = new List<string>
                {
                    "a",
                    "s",
                    "d",
                    "f",
                    "z",
                    "x",
                    "c",
                }
            },
            new EntityRow
            {
                FloorNumber = 3,
                ClassroomNames = new List<string>
                {
                    "v",
                    "q",
                    "w",
                }
            }
        }
    },
    new Entity
    {
        SchoolName = "Okul",
        ClassroomsByFloor = new List<EntityRow>
        {
            new EntityRow
            {
                FloorNumber = 1,
                ClassroomNames = new List<string>
                {
                    "a",
                    "s",
                    "d",
                    "f",

                    "q",
                    "w",
                }
            },
            new EntityRow
            {
                FloorNumber = 2,
                ClassroomNames = new List<string>
                {
                    "a",
                }
            },
            new EntityRow
            {
                FloorNumber = 3,
                ClassroomNames = new List<string>
                {
                    "v",
                    "q",
                    "w",
                }
            }
        }
    },
};
