using PhotovoltaicSystem.Contracts;
using PhotovoltaicSystem.Contracts.Reposotories;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using PhotovoltaicSystem.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Persistence.Repositories.Managers
{
    public class AppRepositoryManager : IAppRepositoryManager
    {
        private readonly AppDbContext _context;

        public AppRepositoryManager(AppDbContext context)
        {
            _context = context;
        }

        private IHousingRepository? _housing;

        public IHousingRepository Housing
        {
            get
            {
                if (_housing is null)
                {
                    _housing = new HousingRepository(_context);
                    return _housing;
                }
                return _housing;
            }

        }

        private IInverterRepository? _inverter;
        public IInverterRepository Invert
        {

            get
            {
                if (_inverter is null)
                {
                    _inverter = new InverterRepository(_context);
                    return _inverter;
                }
                return _inverter;
            }

        }
        private IMaintenanceRecordRepository _maintenanceRecord;

        public IMaintenanceRecordRepository MaintenanceRecord
        {
            get
            {
                if (_maintenanceRecord is null)
                {
                    _maintenanceRecord = new MaintenanceRecordRepository(_context);
                    return _maintenanceRecord;
                }
                return _maintenanceRecord;
            }
        }

        private IPhotovoltaicSystemInstallRepository _photovoltaicSystemInstallRepository;
        public IPhotovoltaicSystemInstallRepository PhotovoltaicSystemInstall
        {
            get
            {
                if (_photovoltaicSystemInstallRepository is null)
                {
                    _photovoltaicSystemInstallRepository = new PhotovoltaicSystemInstallRepository(_context);
                    return (_photovoltaicSystemInstallRepository);
                }
                return _photovoltaicSystemInstallRepository;
            }
        }

        private ISolarPanelRepository _solarPanelRepository;
        public ISolarPanelRepository SolarPanel
        {
            get
            {
                if (_solarPanelRepository is null)
                {
                    _solarPanelRepository = new SolarPanelRepository(_context);
                    return _solarPanelRepository;
                }
                return _solarPanelRepository;
            }
        }

        private IUnitOfWork _unitOfWork;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                if (_unitOfWork is null)
                {
                    _unitOfWork = new UnitOfWork(_context);
                    return _unitOfWork;
                }
                return _unitOfWork;
            }
        }
    }
}
