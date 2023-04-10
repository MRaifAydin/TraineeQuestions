// Calculate each schools classroom count for the given floor. Assign them to a dto. In the end, we should know each school's, each floor's classroom count.

using SumsOfComplexRows;
// Verilen kat için her okulun sınıf sayısını hesaplayın.
// Onları bir dto'ya atayın. Sonunda, her okulun, her katın derslik sayısını bilmeliyiz.
 List<SchoolDto> Calculate(List<Entity> data)
{
    var schoolDtoList = new List<SchoolDto>();

    foreach (var entity in data)
    {
        var schoolDto = new SchoolDto
        {
            SchoolName = entity.SchoolName,
            TotalFloors = entity.ClassroomsByFloor.Count,
            Floors = new List<FloorDto>()
        };

        foreach (var row in entity.ClassroomsByFloor)
        {
            var floorDto = new FloorDto
            {
                FloorNumber = row.FloorNumber,
                TotalClassrooms = row.ClassroomNames.Count
            };

            schoolDto.Floors.Add(floorDto);
        }

        schoolDtoList.Add(schoolDto);
    }

    return schoolDtoList;
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
