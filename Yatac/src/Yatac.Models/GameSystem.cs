using System;

namespace Yatac.Models
{
    public class GameSystem : IBaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
