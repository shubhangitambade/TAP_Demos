using DotnetCoreWebAPI.Model;

//In the service file, we are using the in-memory collection to store all _ourHeroesList data.

namespace DotnetCoreWebAPI.Services
{
    public class OurHeroService : IOurHeroService
    {
        private readonly List<OurHero> _ourHeroesList;
        public OurHeroService() {

            _ourHeroesList = new List<OurHero>()
            {
                new OurHero()
                {
                    Id = 1,
                    FirstName= "Amithabh",
                    LastName="",
                    IsActive= true
                }
            };
        }

        public List<OurHero> GetAllHeros(bool? isActive)
        {
            return isActive == null ? _ourHeroesList : _ourHeroesList.Where(hero => hero.IsActive == isActive).ToList();
        }

        public OurHero? GetHerosByID(int id)
        {
            return _ourHeroesList.FirstOrDefault(hero => hero.Id == id);
        }

        public OurHero AddOurHero(AddUpdateOurHero heroobj)
        {
            var addHero = new OurHero()
            {
                Id = _ourHeroesList.Max(hero => hero.Id) + 1,
                FirstName = heroobj.FirstName,
                LastName = heroobj.LastName,
                IsActive = heroobj.IsActive
            };

            _ourHeroesList.Add(addHero);
            return addHero;
        }
        public OurHero? UpdateOurHero(int id, AddUpdateOurHero obj)
        {
           var OurHeroIndex = _ourHeroesList.FindIndex(index => index.Id == id);
           if(OurHeroIndex> 0)
            {
                var hero = _ourHeroesList[OurHeroIndex];    

                hero.FirstName = obj.FirstName;
                hero.LastName = obj.LastName;
                hero.IsActive = obj.IsActive;

                _ourHeroesList[OurHeroIndex] = hero;
                return hero;
            }
            else
            {
                return null;
            }
        }

        public bool DeleteHerosByID(int id)
        {
            bool status = false;

            OurHero hero = _ourHeroesList.FirstOrDefault(hero => hero.Id == id);
            if(hero != null)
            {
                _ourHeroesList.Remove(hero);
                status = true;
            }

            return status;
        }


    }
}
