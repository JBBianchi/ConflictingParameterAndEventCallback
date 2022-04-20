using System.ComponentModel.DataAnnotations;

namespace ConflictingParameterAndEventCallback.Pages
{
    public class DummyModel
    {
        [Required]
        public string Name { get; set; } = null!;
        public DummyModel() { }
        public DummyModel(string name) { 
            this.Name = name;
        }
    }
}
