using Warehouse.Core.CustomAttributes;

namespace Warehouse.Core
{
    public class TestViewModel
    {
        public DateTime FirstDate { get; set; }

        [IsBefore(nameof(FirstDate), errorMessage: "Boom")]
        public DateTime SecondDate { get; set; }
    }
}
