using Models.Model.PortfolioModel;
using Models.Model.PortfolioViewModel;
using Models.ViewModel;

namespace Services.Services.Portfolio
{
    public interface IPortfolioServices
    {
        //Get All Service
        Task<Response<object>> GetAllByIdAsync(Guid Id);
        Task<Response<object>> GetAllByNameAsync(string Name);


        // Get Service
        Task<Response<PersonalInfoViewModel>> GetPersonalInfoAsync();
        Task<Response<SkillViewModel>> GetSkillAsync();
        Task<Response<ServiceViewModel>> GetServiceAsync();
        Task<Response<ProjectsViewModel>> GetProjectAsync();
        Task<Response<ProjectTypeViewModel>> GetProjectTypeAsync();


        // Add or Update Service
        Task<Response<PersonalInfoViewModel>> AddorUpdatePersonalInfoAsync(PersonalInfoViewModel model);
        Task<Response<SkillViewModel>> AddorUpdateSkillAsync(SkillViewModel model);
        Task<Response<ServiceViewModel>> AddorUpdateServiceAsync(ServiceViewModel model);
        Task<Response<ProjectsViewModel>> AddorUpdateProjectAsync(ProjectsViewModel model);
        Task<Response<ProjectTypeViewModel>> AddorUpdateProjectTypeAsync(ProjectTypeViewModel model);


        //GetByID Service
        Task<Response<PersonalInfoViewModel>> GetByPersonalInfoIdAsync(Guid PersonalInfoId);
        Task<Response<SkillViewModel>> GetBySkillIdAsync(Guid SkillId);
        Task<Response<ServiceViewModel>> GetByServiceIdAsync(Guid ServiceId);
        Task<Response<ProjectsViewModel>> GetByProjectIdAsync(Guid ProjectId);
        Task<Response<ProjectTypeViewModel>> GetByProjectTypeIdAsync(Guid ProjectTypeId);


        //Delete Service
        Task<Response<PersonalInfoViewModel>> DeletePersonalInfoIdAsync(Guid PersonalInfoId);
        Task<Response<SkillViewModel>> DeleteSkillIdAsync(Guid SkillId);
        Task<Response<ServiceViewModel>> DeleteServiceIdAsync(Guid ServiceId);
        Task<Response<ProjectsViewModel>> DeleteProjectIdAsync(Guid ProjectId);
        Task<Response<ProjectTypeViewModel>> DeleteProjectTypeIdAsync(Guid ProjectTypeId);
    }
}
