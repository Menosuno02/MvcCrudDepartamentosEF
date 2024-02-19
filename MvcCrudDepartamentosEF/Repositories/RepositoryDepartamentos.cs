using MvcCrudDepartamentosEF.Data;
using MvcCrudDepartamentosEF.Models;

namespace MvcCrudDepartamentosEF.Repositories
{
    public class RepositoryDepartamentos
    {
        private DepartamentoContext context;

        public RepositoryDepartamentos(DepartamentoContext context)
        {
            this.context = context;
        }

        public List<Departamento> GetDept()
        {
            var consulta = from datos in this.context.Departamentos
                           select datos;
            return consulta.ToList();
        }

        public Departamento FindDept(int id)
        {
            var consulta = from datos in this.context.Departamentos
                           where datos.DeptNo == id
                           select datos;
            return consulta.FirstOrDefault();
        }

        public void CreateDept(Departamento dept)
        {
            this.context.Departamentos.Add(dept);
            this.context.SaveChanges();
        }

        public void UpdateDept(int id, string dnombre, string loc)
        {
            Departamento dept = this.FindDept(id);
            dept.DeptNo = id;
            dept.Dnombre = dnombre;
            dept.Localidad = loc;
            this.context.SaveChanges();
        }

        public void DeleteDept(int id)
        {
            Departamento dept = this.FindDept(id);
            this.context.Departamentos.Remove(dept);
            this.context.SaveChanges();
        }
    }
}
