namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class Pet
    {
        public Pet(DTOs.CharacterProfile.Pet dto)
        {
            Icon = dto.Icon;
            Name = dto.Name;
        }

        public string Icon { get; }
        public string Name { get; }
    }
}