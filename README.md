# DotNet 7 Template

�o���ɮױN�|�����p��q�o�ӼҪO���}�l�s����ݸѨM���

## �ϥΫe

1. �Х��N API�BRepository �M�צW�٭��s�R�W
2. �N�T�{�U���O�P�������R�W�Ŷ��O�_���T

## appSettings.json

�p�ݨϥθ�Ʈw�A�Х��} `ServiceProviders/DatabaseServiceProvider.cs` �N���ѥ������}�A�íק� DBContext �W�٬����T���W�١A�P�ɽбN��Ʈw�s�u�r��B��Ʈw�b���P�K�X�]�w�����A�_�h�M�ױN�L�k�Ұ�

## Service �P Repository ���O�P�����j�w

Service �P Repository �����O�P�����ݶi��j�w�A�_�h DI �N�L�k���`�`�J

1. ���} `ServiceProviders/ServiceMapperProvider.cs`�A�̾ڽd�ұN���O�P�����j�w�_��

## Repository �M�׳]�w

1. ���N Repository �M�׳]�w���ҰʱM��
2. �ϥΥH�U���O�N���w��Ʈw������ƪ�i��ϦV�u�{�A�إߥX Model ����

	```Powershell
	Scaffold-DbContext "Server=<SERVER_URI>; Port=<SERVER_PORT>; Database=<DATABASE_NAME>; User ID=<DATABASE_USERNAME>; Password=<DATABASE_PASSWORD>" Pomelo.EntityFrameworkCore.MySql -OutputDir Models -ContextDir DBContexts -Tables <TABLE_NAME> Project <REPOSITORY_PROJECT_NAME> -Force -NoOnConfiguring
	```

3. ���} `ServiceProviders/DatabaseServiceProvider.cs`�A�N�̤U�誺���ѥ��}�A�ñN DBContext �קאּ���T�����O
	> �Y���h�� DBContext �]�Цb�o��@�ëŧi
4. �N Api �M�׳]�w���ҰʱM��

## AutoMapper Profile �ŧi

1. �b `AutoMapperProfiles` ��Ƨ��U�s�W�@�� ���N�W�٪� Profile ���O
2. �b���O���ŧi�ݭn�i�� Mapper �����O�j�w

## �ѦҸ��

- [Using the Repository Pattern with the Entity Framework](https://medium.com/@mlbors/using-the-repository-pattern-with-the-entity-framework-fa4679f2139)
- [Scaffolding (Reverse Engineering)](https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding/?tabs=vs)
- [Get ConnectionString from appsettings.json](https://stackoverflow.com/a/45845041)
- [Setting connection string with username and password in ASP.Core](https://stackoverflow.com/a/41624833)
- [[EF Core] �ϥ�.NET Core CLI�إ߸�Ʈw��������](https://dotblogs.com.tw/jerry809/2019/03/13/105934)
- [Creating a Model for an Existing Database in Entity Framework Core](https://www.entityframeworktutorial.net/efcore/create-model-for-existing-database-in-ef-core.aspx)
- [Pomelo EntityFrameworkCore Mysql - Getting Started](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql/blob/master/README.md#getting-started)
- [AutoMapper �X�X ���O�ഫ�W�٤O](https://igouist.github.io/post/2020/07/automapper/)
- [Dependency Injection - Automapper documentation](https://docs.automapper.org/en/stable/Dependency-injection.html)
