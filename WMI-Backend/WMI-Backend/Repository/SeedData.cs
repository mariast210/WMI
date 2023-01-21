using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using WMI_Backend.Models;

namespace WMI_Backend.Repository
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var repository = serviceProvider.GetRequiredService<CarsRepository>();

            if (repository.GetTotalCount() !=
              default)
            {
                return;
            }

            var data = new List<Car> {
                new Car {
                    Country = null,
                    CreatedOn = DateTimeOffset.Parse("2015-03-26"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    UpdatedOn = DateTimeOffset.Parse("2015-06-04"),
                    VehicleType = "Passenger Car",
                    WMI = "JHM"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-03-26"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF AMERICA MFG., INC.",
                    UpdatedOn = null,
                    VehicleType = "Passenger Car",
                    WMI = "1HG"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-03-26"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA MFG., ALABAMA., LLC.",
                    UpdatedOn = null,
                    VehicleType = "Passenger Car",
                    WMI = "5KB"
                },
                new Car {
                    Country = "CANADA",
                    CreatedOn = DateTimeOffset.Parse("2015-03-26"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF CANADA MFG., INC.",
                    UpdatedOn = null,
                    VehicleType = "Passenger Car",
                    WMI = "2HG"
                },
                new Car {
                    Country = "UNITED KINGDOM (UK)",
                    CreatedOn = DateTimeOffset.Parse("2015-03-26"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF THE U.K. MFG., LTD.",
                    UpdatedOn = null,
                    VehicleType = "Passenger Car",
                    WMI = "SHH"
                },
                new Car {
                    Country = "MEXICO",
                    CreatedOn = DateTimeOffset.Parse("2015-03-26"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA DE MEXICO",
                    UpdatedOn = null,
                    VehicleType = "Passenger Car",
                    WMI = "3HG"
                },
                new Car {
                    Country = null,
                    CreatedOn = DateTimeOffset.Parse("2015-03-26"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA MFG., INDIANA., LLC.",
                    UpdatedOn = null,
                    VehicleType = "Passenger Car",
                    WMI = "19X"
                },
                new Car {
                    Country = null,
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA MOTOR CO., LTD",
                    UpdatedOn = null,
                    VehicleType = "Passenger Car",
                    WMI = "JH4"
                },
                new Car {
                    Country = null,
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA MOTOR CO., LTD",
                    UpdatedOn = null,
                    VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                    WMI = "JHL"
                },
                new Car {
                    Country = null,
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA MOTOR CO., LTD",
                    UpdatedOn = null,
                    VehicleType = "Truck ",
                    WMI = "JH1"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF AMERICA MFG., INC.",
                    UpdatedOn = DateTimeOffset.Parse("2015-03-27"),
                    VehicleType = "Passenger Car",
                    WMI = "19U"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF AMERICA MFG., INC.",
                    UpdatedOn = null,
                    VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                    WMI = "5J6"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF AMERICA MFG., INC.",
                    UpdatedOn = DateTimeOffset.Parse("2015-03-27"),
                    VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                    WMI = "5J8"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF AMERICA MFG., INC.",
                    UpdatedOn = null,
                    VehicleType = "Truck ",
                    WMI = "5J7"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF AMERICA MFG., INC.",
                    UpdatedOn = null,
                    VehicleType = "Truck ",
                    WMI = "5J0"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA MFG., ALABAMA., LLC.",
                    UpdatedOn = null,
                    VehicleType = "Passenger Car",
                    WMI = "5KC"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA MFG., ALABAMA., LLC.",
                    UpdatedOn = null,
                    VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                    WMI = "5FN"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA MFG., ALABAMA., LLC.",
                    UpdatedOn = null,
                    VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                    WMI = "5FR"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA MFG., ALABAMA., LLC.",
                    UpdatedOn = null,
                    VehicleType = "Truck ",
                    WMI = "5FP"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA MFG., ALABAMA., LLC.",
                    UpdatedOn = null,
                    VehicleType = "Truck ",
                    WMI = "5FS"
                },
                new Car {
                    Country = "CANADA",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF CANADA MFG., INC.",
                    UpdatedOn = DateTimeOffset.Parse("2015-03-27"),
                    VehicleType = "Passenger Car",
                    WMI = "2HH"
                },
                new Car {
                    Country = "CANADA",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF CANADA MFG., INC.",
                    UpdatedOn = null,
                    VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                    WMI = "2HK"
                },
                new Car {
                    Country = "CANADA",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF CANADA MFG., INC.",
                    UpdatedOn = null,
                    VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                    WMI = "2HN"
                },
                new Car {
                    Country = "CANADA",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF CANADA MFG., INC.",
                    UpdatedOn = null,
                    VehicleType = "Truck ",
                    WMI = "2HJ"
                },
                new Car {
                    Country = "CANADA",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF CANADA MFG., INC.",
                    UpdatedOn = null,
                    VehicleType = "Truck ",
                    WMI = "2HU"
                },
                new Car {
                    Country = "UNITED KINGDOM (UK)",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF THE U.K. MFG., LTD.",
                    UpdatedOn = null,
                    VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                    WMI = "SHS"
                },
                new Car {
                    Country = "MEXICO",
                    CreatedOn = DateTimeOffset.Parse("2015-03-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA DE MEXICO",
                    UpdatedOn = null,
                    VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                    WMI = "3CZ"
                },
                new Car {
                    Country = null,
                    CreatedOn = DateTimeOffset.Parse("2015-04-03"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "AMERICAN HONDA MOTOR CO., INC.",
                    UpdatedOn = DateTimeOffset.Parse("2015-06-04"),
                    VehicleType = "Motorcycle",
                    WMI = "JH2"
                },
                new Car {
                    Country = null,
                    CreatedOn = DateTimeOffset.Parse("2015-04-03"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "AMERICAN HONDA MOTOR CO., INC.",
                    UpdatedOn = DateTimeOffset.Parse("2015-06-04"),
                    VehicleType = "Motorcycle",
                    WMI = "1HF"
                },
                new Car {
                    Country = "BELGIUM",
                    CreatedOn = DateTimeOffset.Parse("2015-04-03"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF AMERICA MFG., INC.",
                    UpdatedOn = DateTimeOffset.Parse("2016-07-08"),
                    VehicleType = "Motorcycle",
                    WMI = "YC1"
                },
                new Car {
                    Country = null,
                    CreatedOn = DateTimeOffset.Parse("2015-04-03"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "AMERICAN HONDA MOTOR CO., INC.",
                    UpdatedOn = DateTimeOffset.Parse("2015-06-04"),
                    VehicleType = "Motorcycle",
                    WMI = "3H1"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-04-21"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA MFG., INDIANA., LLC.",
                    UpdatedOn = null,
                    VehicleType = "Passenger Car",
                    WMI = "19V"
                },
                new Car {
                    Country = null,
                    CreatedOn = DateTimeOffset.Parse("2015-06-04"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "AMERICAN HONDA MOTOR CO., INC.",
                    UpdatedOn = DateTimeOffset.Parse("2016-06-17"),
                    VehicleType = "Motorcycle",
                    WMI = "ZDC"
                },
                new Car {
                    Country = null,
                    CreatedOn = DateTimeOffset.Parse("2015-06-04"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "AMERICAN HONDA MOTOR CO., INC.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "MLH"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-06-04"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "SUNDIRO HONDA MOTORCYCLE CO., LTD.",
                    UpdatedOn = DateTimeOffset.Parse("2017-08-01"),
                    VehicleType = "Motorcycle",
                    WMI = "LAL"
                },
                new Car {
                    Country = null,
                    CreatedOn = DateTimeOffset.Parse("2015-06-04"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "AMERICAN HONDA MOTOR CO., INC.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "RLH"
                },
                new Car {
                    Country = null,
                    CreatedOn = DateTimeOffset.Parse("2015-06-04"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "AMERICAN HONDA MOTOR CO., INC.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "VTM"
                },
                new Car {
                    Country = null,
                    CreatedOn = DateTimeOffset.Parse("2015-06-04"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "AMERICAN HONDA MOTOR CO., INC.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "LWB"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-07-07"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "CHONGQING GUANGYU MOTORCYCLE MANUFACTURE CO., LTD.",
                    UpdatedOn = DateTimeOffset.Parse("2019-11-06"),
                    VehicleType = "Motorcycle",
                    WMI = "LRY"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-07-07"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "CHONGQING HI-BIRD MOTORCYCLE INDUSTRY CO., LTD.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "LSR"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-07-07"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "CHONGQING KAIER MOTORCYCLE MANUFACTURING CO.,",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "LYE"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-07-07"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "CHONGQING KINLON MOTORCYCLE MANUFACTURE CO., LTD",
                    UpdatedOn = DateTimeOffset.Parse("2015-07-22"),
                    VehicleType = "Motorcycle",
                    WMI = "LLC"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-07-07"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "CHONGQING HUANSONG INDUSTRIES (GROUP) CO., LTD.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "LWG"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-07-07"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "CHONGQING RATO POWER CO., LTD.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "LRP"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-07-07"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "CHONGQING YINXIANG MOTORCYCLE (GROUP) CO., LTD.",
                    UpdatedOn = DateTimeOffset.Parse("2015-09-15"),
                    VehicleType = "Motorcycle",
                    WMI = "LB4"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-07-15"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "AMERICAN HONDA MOTOR CO., INC.",
                    UpdatedOn = null,
                    VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                    WMI = "JR2"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-07-16"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "WUXI JINHONG MOTORCYCLE CO., LTD",
                    UpdatedOn = DateTimeOffset.Parse("2017-08-22"),
                    VehicleType = "Motorcycle",
                    WMI = "LC3"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-07-20"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "JOYHON, INC.",
                    UpdatedOn = null,
                    VehicleType = "Trailer",
                    WMI = "1J9390"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-07-20"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "CHANGZHOU ZHONGMAO MACHINERY CO., LTD",
                    UpdatedOn = null,
                    VehicleType = "Trailer",
                    WMI = "L0H"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-07-21"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "CHONGQING ASTRONAUTIC BASHAN MOTORCYCLE MANUFACTURING CO., LTD.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "LHJ"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-07-23"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "MARATHON METALWORKS",
                    UpdatedOn = null,
                    VehicleType = "Trailer",
                    WMI = "1M9822"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-07-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-07-27"),
                    Name = "CHONGQING HENSIM GROUP CO., LTD.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "LUA"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-08-05"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-08-05"),
                    Name = "JIANGMEN SINO-HONGKONG BAOTIAN MOTORCYCLE INDUSTRIAL CO., LTD.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "L82"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-08-07"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-08-07"),
                    Name = "SHANDONG ZHONGTONG FEIYAN AUTOMOBILE CO. LTD.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "L69FYK"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-08-10"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-08-10"),
                    Name = "TAIZHOU ZHONGNENG MOTORCYCLE CO., LTD.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "L5Y"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-08-11"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-08-11"),
                    Name = "SHANGHAI HUIZHONG AUTOMOTIVE MANUFACTURING CO., LTD",
                    UpdatedOn = null,
                    VehicleType = "Trailer",
                    WMI = "LSB"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-08-11"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-08-11"),
                    Name = "SHANGHAI HONLING MOTORCYCLE MANUFACTURE CO., LTD.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "LLA"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-08-31"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-08-31"),
                    Name = "CHONGQING ANDES MOTORCYCLE MANUFACTURING CO.,LTD.",
                    UpdatedOn = DateTimeOffset.Parse("2020-05-01"),
                    VehicleType = "Motorcycle",
                    WMI = "LKX"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-09-03"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-09-03"),
                    Name = "CHONGQING SHUANGQING MECHANICAL & ELECTRICAL CO.",
                    UpdatedOn = DateTimeOffset.Parse("2016-06-24"),
                    VehicleType = "Motorcycle",
                    WMI = "LZX"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-09-04"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-09-04"),
                    Name = "CHONGQUING DAJIANG MOTORCYCLES CO., LTD",
                    UpdatedOn = DateTimeOffset.Parse("2019-11-07"),
                    VehicleType = "Motorcycle",
                    WMI = "L1P"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-09-16"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-09-16"),
                    Name = "MARATHON HOMES CORPORATION",
                    UpdatedOn = null,
                    VehicleType = "Trailer",
                    WMI = "1M9019"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-11-06"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-11-06"),
                    Name = "Xinri E-Vehicle Hongkong Co., Limited",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "R12"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2015-12-17"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-12-17"),
                    Name = "CHONGQING SHINERAY MOTORCYCLE CO., LTD.",
                    UpdatedOn = DateTimeOffset.Parse("2018-08-06"),
                    VehicleType = "Motorcycle",
                    WMI = "LXY"
                },
                new Car {
                    Country = null,
                    CreatedOn = DateTimeOffset.Parse("2015-12-30"),
                    DateAvailableToPublic = DateTimeOffset.Parse("1988-12-30"),
                    Name = "AMERICAN HONDA MOTOR CO., INC.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "9C2"
                },
                new Car {
                    Country = "JAPAN",
                    CreatedOn = DateTimeOffset.Parse("2016-06-08"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2016-06-08"),
                    Name = "HONDA MOTOR CO., LTD",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "JH3"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2016-06-08"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2016-06-08"),
                    Name = "HONDA MFG., INDIANA., LLC.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "478"
                },
                new Car {
                    Country = "SPAIN",
                    CreatedOn = DateTimeOffset.Parse("2016-06-17"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2016-06-17"),
                    Name = "MONTESA HONDA SA",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "VTD"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2016-08-31"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2016-08-31"),
                    Name = "CHONGQING YINGANG SCIENCE & TECHNOLOGY (GROUP) CO., LTD.",
                    UpdatedOn = DateTimeOffset.Parse("2016-09-01"),
                    VehicleType = "Motorcycle",
                    WMI = "LY4"
                },
                new Car {
                    Country = "HONG KONG",
                    CreatedOn = DateTimeOffset.Parse("2016-10-26"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2016-10-26"),
                    Name = "RONGCHENG COMPAKS (HONG KONG) NEW ENERGY AUTOMOBILE CO LTD",
                    UpdatedOn = null,
                    VehicleType = "Trailer",
                    WMI = "R1V"
                },
                new Car {
                    Country = "CANADA",
                    CreatedOn = DateTimeOffset.Parse("2017-02-22"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2017-02-22"),
                    Name = "MARATHON EQUIPMENT LTD ",
                    UpdatedOn = DateTimeOffset.Parse("2017-04-11"),
                    VehicleType = "Trailer",
                    WMI = "2M9004"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2017-03-09"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2017-03-09"),
                    Name = "HONDA MFG., INDIANA., LLC.",
                    UpdatedOn = null,
                    VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                    WMI = "7FA"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2017-05-08"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2017-05-08"),
                    Name = "GRYPHON BIKES & CHOPPERS",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "1G9340"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2017-05-17"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2017-05-17"),
                    Name = "JIANGMEN ZHONGYU MOTOR (GROUP) CO., LTD.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "LMF"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2017-05-23"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2017-05-23"),
                    Name = "JHC NEW ENERGY VEHICLE HONGKONG CO.,LTD",
                    UpdatedOn = null,
                    VehicleType = "Low Speed Vehicle (LSV)",
                    WMI = "R1A"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2017-06-27"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2017-06-27"),
                    Name = "NANCHANG AIRCRAFT MFG. CO ( HONGDU MACHINERY PLANT)",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "LPP"
                },
                new Car {
                    Country = "UNITED KINGDOM (UK)",
                    CreatedOn = DateTimeOffset.Parse("2017-11-03"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2017-11-03"),
                    Name = "HONNOR MARINE LTD",
                    UpdatedOn = null,
                    VehicleType = "Trailer",
                    WMI = "SA9112"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2018-01-17"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2018-01-17"),
                    Name = "HONGDU ELECTRIC VEHICLE HONGKONG CO.,LIMITED",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "R2L"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2018-01-25"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2018-01-25"),
                    Name = "HONGDOU GROUP CHITUMA MOTORCYCLE COMPANY",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "LE6"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2018-03-14"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2018-03-14"),
                    Name = "MARATHON EQUIPMENT COMPANY (DEL)",
                    UpdatedOn = null,
                    VehicleType = "Trailer",
                    WMI = "1M9371"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2018-05-11"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2018-05-11"),
                    Name = "CHONGQING HUANGHE MOTORCYCLE CO.,LTD. ",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "LDU"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2018-08-10"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2018-08-10"),
                    Name = "CHONGQING LIYANG JIAYU MOTORCYCLE CO., LTD.",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "LC4"
                },
                new Car {
                    Country = "CHINA",
                    CreatedOn = DateTimeOffset.Parse("2020-08-31"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2020-08-31"),
                    Name = "ELYX SMART TECHNOLOGY HOLDINGS (HONGKONG) LIMITED",
                    UpdatedOn = null,
                    VehicleType = "Motorcycle",
                    WMI = "R4N"
                }
            };
            repository.InsertMany(data);
        }
    }
}