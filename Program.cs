using FactoryPattern;
using FactoryPattern.Factories;

HeroesFactory orcFactory = new OrcFactory();
HeroesFactory elfFactory = new ElfFactory();

HeroesSpawn orcs = new HeroesSpawn(orcFactory);
HeroesSpawn elfs = new HeroesSpawn(elfFactory);

elfs.Fight(orcs);

