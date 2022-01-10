using Comp337.Business.Abstract;
using Comp337.Business.Concrete;
using Comp337.DataAccess.Abstract;
using Comp337.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Comp337.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAdvisorService>().To<AdvisorManager>().InSingletonScope();
            Bind<IAdvisorDal>().To<EfAdvisorDal>().InSingletonScope();

            Bind<IClassroomService>().To<ClassroomManager>().InSingletonScope();
            Bind<IClassroomDal>().To<EfClassroomDal>().InSingletonScope();

            Bind<ICourseService>().To<CourseManager>().InSingletonScope();
            Bind<ICourseDal>().To<EfCourseDal>().InSingletonScope();

            Bind<ICourseInstructorService>().To<CourseInstructorManager>().InSingletonScope();
            Bind<ICourseInstructorDal>().To<EfCourseInstructorDal>();

            Bind<IDepartmentService>().To<DeparmentManager>().InSingletonScope();
            Bind<IDepartmentDal>().To<EfDepartmentDal>().InSingletonScope();

            Bind<IInstructorService>().To<InstructorManager>().InSingletonScope();
            Bind<IInstructorDal>().To<EfInstructorDal>().InSingletonScope();

            Bind<ISectionService>().To<SectionManager>().InSingletonScope();
            Bind<ISectionDal>().To<EfSectionDal>().InSingletonScope();

            Bind<IStudentService>().To<StudentManager>().InSingletonScope();
            Bind<IStudentDal>().To<EfStudentDal>().InSingletonScope();

            Bind<ITimeSlotService>().To<TimeSlotManager>().InSingletonScope();
            Bind<ITimeSlotDal>().To<EfTimeSlotDal>().InSingletonScope();

            Bind<IUserAuthorizationService>().To<UserAuthorizationManager>().InSingletonScope();
            Bind<IUserAuthorizationDal>().To<EfUserAuthorizationDal>();

            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();



        }
    }
}