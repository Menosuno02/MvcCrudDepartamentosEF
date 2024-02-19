using Microsoft.AspNetCore.Mvc;
using MvcCrudDepartamentosEF.Models;
using MvcCrudDepartamentosEF.Repositories;

namespace MvcCrudDepartamentosEF.Controllers
{
    public class DepartamentosController : Controller
    {
        private RepositoryDepartamentos repo;

        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Departamento> dept = this.repo.GetDept();
            return View(dept);
        }

        public IActionResult Details(int id)
        {
            Departamento dept = this.repo.FindDept(id);
            return View(dept);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Departamento dept)
        {
            this.repo.CreateDept(dept);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            Departamento dept = this.repo.FindDept(id);
            return View(dept);
        }

        [HttpPost]
        public IActionResult Update(Departamento dept)
        {
            this.repo.UpdateDept(dept.DeptNo, dept.Dnombre, dept.Localidad);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            this.repo.DeleteDept(id);
            return RedirectToAction("Index");
        }
    }
}
