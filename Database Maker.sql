CREATE TABLE [Contractor_Info] (
	Contractor_Name varchar(255) NOT NULL,
	Contractor_Category varchar(255) NOT NULL,
	Contractor_Contact varchar(255) NOT NULL,
	Contractor_Specialization varchar(255) NOT NULL,
	Work_Experience integer NOT NULL,
	PEC_Registration_Number varchar(255) NOT NULL,
	SRB_Regestration_Number varchar(255) NOT NULL,
	Contractor_IBAN integer NOT NULL,
  CONSTRAINT [PK_CONTRACTOR_INFO] PRIMARY KEY CLUSTERED
  (
  [Contractor_Name] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Machinery] (
	Vehicle_Reg_No varchar(255) NOT NULL,
	Vehicle_Category varchar(255) NOT NULL,
	Aquisation_Date date NOT NULL,
	[Make/Model] varchar(255) NOT NULL,
  CONSTRAINT [PK_MACHINERY] PRIMARY KEY CLUSTERED
  (
  [Vehicle_Reg_No] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Contractor_Owns_Machinery] (
	Contractor_Name varchar(255) NOT NULL,
	Vehicle_Reg_No varchar(255) NOT NULL,
  CONSTRAINT [PK_CONTRACTOR_OWNS_MACHINERY] PRIMARY KEY CLUSTERED
  (
  [Contractor_Name] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Road] (
	Road_Name varchar(255) NOT NULL,
	Length_KM float NOT NULL,
	Width_KM float NOT NULL,
	Material_Thickness float NOT NULL,
	Embankment_Height float NOT NULL,
	Right_of_Way float NOT NULL,
	[Fencing] bit NOT NULL,
	Construction_Cost float NOT NULL,
	Design_Life varchar(255) NOT NULL,
	Traffic_Level integer NOT NULL,
  CONSTRAINT [PK_ROAD] PRIMARY KEY CLUSTERED
  (
  [Road_Name] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Executing_Agency] (
	Head_Contact varchar(255) NOT NULL,
	Executing_Agency_Name varchar(255) NOT NULL,
	Executing_Agency_Contact varchar(255) NOT NULL,
	Executing_Agency_IBAN integer NOT NULL,
	Type varchar(255) NOT NULL,
	Head_Name varchar(255) NOT NULL,
  CONSTRAINT [PK_EXECUTING_AGENCY] PRIMARY KEY CLUSTERED
  (
  [Executing_Agency_Name] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Executing_Agency_Employees] (
	ID integer NOT NULL,
	Name varchar(255) NOT NULL,
	Work_Experience varchar(255) NOT NULL,
	Qualification varchar(255) NOT NULL,
	Insurance_ID integer NOT NULL,
	Contact varchar(255) NOT NULL,
	Password varchar(255) NOT NULL,
	Executing_Agency_Name varchar(255) NOT NULL,
  CONSTRAINT [PK_EXECUTING_AGENCY_EMPLOYEES] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Contractor_Employees] (
	Contractor_Name varchar(255) NOT NULL,
	ID integer NOT NULL,
	Name varchar(255) NOT NULL,
	Work_Experience varchar(255) NOT NULL,
	Qualification varchar(255) NOT NULL,
	Insurance_ID integer NOT NULL,
	[Technical/Non_Technical] bit NOT NULL,
	Contact varchar(255) NOT NULL,
	Password varchar(255) NOT NULL,
  CONSTRAINT [PK_CONTRACTOR_EMPLOYEES] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Project] (
	Project_ID integer NOT NULL,
	Project_Name varchar(255) NOT NULL,
	Project_Director_ID integer NOT NULL,
	Project_Director_Name varchar(255) NOT NULL,
	Executing_Agency_Name varchar(255) NOT NULL,
	Completion_Period float NOT NULL,
	Cost_Estimate float NOT NULL,
	Progress_Percentage float NOT NULL,
	Budget_Allocation float NOT NULL,
	No_of_Contracts integer NOT NULL,
	Road_Name varchar(255) NOT NULL,
  CONSTRAINT [PK_PROJECT] PRIMARY KEY CLUSTERED
  (
  [Project_ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Project_Feasibility] (
	Project_ID integer,
	Feasibility_Report_No integer NOT NULL,
	Road_Length float NOT NULL,
	Road_Width float NOT NULL,
	Initial_Cost_Estimate integer NOT NULL,
	Connecting_Villages integer NOT NULL,
	Connecting_Towns integer NOT NULL,
	Connecting_Cities integer NOT NULL,
	Socioeconomic_Benefits text NOT NULL,
  CONSTRAINT [PK_PROJECT_FEASIBILITY] PRIMARY KEY CLUSTERED
  (
  [Feasibility_Report_No] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Estimated_Traffic_Count] (
	Feasibility_Report_No integer NOT NULL,
	Vehicle_Category varchar(255) NOT NULL,
	Traffic_Count integer NOT NULL,
	Traffic_Growth_rate float NOT NULL,
	Average_CO2_Emissions float NOT NULL,
  CONSTRAINT [PK_ESTIMATED_TRAFFIC_COUNT] PRIMARY KEY CLUSTERED
  (
  [Feasibility_Report_No] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Contract_Info] (
	Project_Manager_ID integer NOT NULL,
	Project_Manager binary NOT NULL,
	Contractor_Name integer NOT NULL,
	Contract_No integer NOT NULL,
	Contractor_Bill float NOT NULL,
	Contract_Awarded_For_Road_Length integer NOT NULL,
	Project_ID integer NOT NULL,
  CONSTRAINT [PK_CONTRACT_INFO] PRIMARY KEY CLUSTERED
  (
  [Contract_No] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Current_Traffic_Count] (
	Road_Name varchar(255) NOT NULL,
	Timeslot datetime NOT NULL,
	Vehicle_Category varchar(255) NOT NULL,
	Traffic_Count integer NOT NULL,
	Traffic_Growth_Rate float NOT NULL,
	Average_CO2_Emissions float NOT NULL,
  CONSTRAINT [PK_CURRENT_TRAFFIC_COUNT] PRIMARY KEY CLUSTERED
  (
  [Road_Name] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Funding_Organisation] (
	Organisation_Name varchar(255) NOT NULL,
	Organisation_IBAN varchar(255) NOT NULL,
	Incharge_Name varchar(255) NOT NULL,
	Incharge_Contact varchar(255) NOT NULL,
  CONSTRAINT [PK_FUNDING_ORGANISATION] PRIMARY KEY CLUSTERED
  (
  [Organisation_Name] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Damage] (
	Road_Name varchar(255) NOT NULL,
	Damage_Report_ID integer NOT NULL,
	Damage_Report_Date datetime NOT NULL,
	Damage_Section_Length float NOT NULL,
	Damage_Type float NOT NULL,
	Damage_Description text NOT NULL,
  CONSTRAINT [PK_DAMAGE] PRIMARY KEY CLUSTERED
  (
  [Damage_Report_ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Maintenence] (
	Executing_Agency_Name float NOT NULL,
	Damaage_Report_ID integer NOT NULL,
	Maintenance_Report_ID integer NOT NULL,
	Maintenance_Report_Date datetime NOT NULL,
	M_Budget_Allocation float NOT NULL,
	M_Estimate float NOT NULL,
	Completion_Period float NOT NULL,
  CONSTRAINT [PK_MAINTENENCE] PRIMARY KEY CLUSTERED
  (
  [Maintenance_Report_ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [City/Town/Village] (
	Name varchar(255) NOT NULL,
	District varchar(255) NOT NULL,
	Division varchar(255) NOT NULL,
	Province varchar(255) NOT NULL,
	Population integer NOT NULL,
  CONSTRAINT [PK_CITY/TOWN/VILLAGE] PRIMARY KEY CLUSTERED
  (
  [Name] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [City/Town/Village_Has_Road] (
	Road_Name varchar(255) NOT NULL,
	Name varchar(255) NOT NULL,
  CONSTRAINT [PK_CITY/TOWN/VILLAGE_HAS_ROAD] PRIMARY KEY CLUSTERED
  (
  [Road_Name] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Assignment] (
	ID integer NOT NULL,
	Project_ID integer NOT NULL,
	Assignment varchar(255) NOT NULL,
  CONSTRAINT [PK_ASSIGNMENT] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Funds] (
	Organisation_Name varchar(255) NOT NULL,
	Project_ID integer NOT NULL,
	Percentage float NOT NULL,
	Type varchar(255) NOT NULL,
  CONSTRAINT [PK_FUNDS] PRIMARY KEY CLUSTERED
  (
  [Organisation_Name] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO


ALTER TABLE [Contractor_Owns_Machinery] WITH CHECK ADD CONSTRAINT [Contractor_Owns_Machinery_fk0] FOREIGN KEY ([Contractor_Name]) REFERENCES [Contractor Info]([Contractor_Name])
ON UPDATE CASCADE
GO
ALTER TABLE [Contractor_Owns_Machinery] CHECK CONSTRAINT [Contractor_Owns_Machinery_fk0]
GO
ALTER TABLE [Contractor_Owns_Machinery] WITH CHECK ADD CONSTRAINT [Contractor_Owns_Machinery_fk1] FOREIGN KEY ([Vehicle_Reg_No]) REFERENCES [Machinery]([Vehicle_Reg_No])
ON UPDATE CASCADE
GO
ALTER TABLE [Contractor_Owns_Machinery] CHECK CONSTRAINT [Contractor_Owns_Machinery_fk1]
GO



ALTER TABLE [Executing_Agency_Employees] WITH CHECK ADD CONSTRAINT [Executing_Agency_Employees_fk0] FOREIGN KEY ([Executing_Agency_Name]) REFERENCES [Executing_Agency]([Executing_Agency_Name])
ON UPDATE CASCADE
GO
ALTER TABLE [Executing_Agency_Employees] CHECK CONSTRAINT [Executing_Agency_Employees_fk0]
GO

ALTER TABLE [Contractor_Employees] WITH CHECK ADD CONSTRAINT [Contractor_Employees_fk0] FOREIGN KEY ([Contractor_Name]) REFERENCES [Contractor Info]([Contractor_Name])
ON UPDATE CASCADE
GO
ALTER TABLE [Contractor_Employees] CHECK CONSTRAINT [Contractor_Employees_fk0]
GO

ALTER TABLE [Project] WITH CHECK ADD CONSTRAINT [Project_fk0] FOREIGN KEY ([Project_Director_ID]) REFERENCES [Executing_Agency_Employees]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [Project] CHECK CONSTRAINT [Project_fk0]
GO
ALTER TABLE [Project] WITH CHECK ADD CONSTRAINT [Project_fk1] FOREIGN KEY ([Executing_Agency_Name]) REFERENCES [Executing_Agency]([Executing_Agency_Name])
ON UPDATE CASCADE
GO
ALTER TABLE [Project] CHECK CONSTRAINT [Project_fk1]
GO
ALTER TABLE [Project] WITH CHECK ADD CONSTRAINT [Project_fk2] FOREIGN KEY ([Road_Name]) REFERENCES [Road]([Road_Name])
ON UPDATE CASCADE
GO
ALTER TABLE [Project] CHECK CONSTRAINT [Project_fk2]
GO

ALTER TABLE [Project_Feasibility] WITH CHECK ADD CONSTRAINT [Project_Feasibility_fk0] FOREIGN KEY ([Project_ID]) REFERENCES [Project]([Project_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [Project_Feasibility] CHECK CONSTRAINT [Project_Feasibility_fk0]
GO

ALTER TABLE [Estimated_Traffic_Count] WITH CHECK ADD CONSTRAINT [Estimated_Traffic_Count_fk0] FOREIGN KEY ([Feasibility_Report_No]) REFERENCES [Project Feasibility]([Feasibility_Report_No])
ON UPDATE CASCADE
GO
ALTER TABLE [Estimated_Traffic_Count] CHECK CONSTRAINT [Estimated_Traffic_Count_fk0]
GO

ALTER TABLE [Contract_Info] WITH CHECK ADD CONSTRAINT [Contract_Info_fk0] FOREIGN KEY ([Project_Manager_ID]) REFERENCES [Contractor_Employees]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [Contract_Info] CHECK CONSTRAINT [Contract_Info_fk0]
GO
ALTER TABLE [Contract_Info] WITH CHECK ADD CONSTRAINT [Contract_Info_fk1] FOREIGN KEY ([Contractor_Name]) REFERENCES [Contractor Info]([Contractor_Name])
ON UPDATE CASCADE
GO
ALTER TABLE [Contract_Info] CHECK CONSTRAINT [Contract_Info_fk1]
GO
ALTER TABLE [Contract_Info] WITH CHECK ADD CONSTRAINT [Contract_Info_fk2] FOREIGN KEY ([Project_ID]) REFERENCES [Project]([Project_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [Contract_Info] CHECK CONSTRAINT [Contract_Info_fk2]
GO

ALTER TABLE [Current_Traffic_Count] WITH CHECK ADD CONSTRAINT [Current_Traffic_Count_fk0] FOREIGN KEY ([Road_Name]) REFERENCES [Road]([Road_Name])
ON UPDATE CASCADE
GO
ALTER TABLE [Current_Traffic_Count] CHECK CONSTRAINT [Current_Traffic_Count_fk0]
GO


ALTER TABLE [Damage] WITH CHECK ADD CONSTRAINT [Damage_fk0] FOREIGN KEY ([Road_Name]) REFERENCES [Road]([Road_Name])
ON UPDATE CASCADE
GO
ALTER TABLE [Damage] CHECK CONSTRAINT [Damage_fk0]
GO

ALTER TABLE [Maintenence] WITH CHECK ADD CONSTRAINT [Maintenence_fk0] FOREIGN KEY ([Executing_Agency_Name]) REFERENCES [Executing_Agency]([Executing_Agency_Name])
ON UPDATE CASCADE
GO
ALTER TABLE [Maintenence] CHECK CONSTRAINT [Maintenence_fk0]
GO
ALTER TABLE [Maintenence] WITH CHECK ADD CONSTRAINT [Maintenence_fk1] FOREIGN KEY ([Damaage_Report_ID]) REFERENCES [Damage]([Damage_Report_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [Maintenence] CHECK CONSTRAINT [Maintenence_fk1]
GO


ALTER TABLE [City/Town/Village_Has_Road] WITH CHECK ADD CONSTRAINT [City/Town/Village_Has_Road_fk0] FOREIGN KEY ([Road_Name]) REFERENCES [Road]([Road_Name])
ON UPDATE CASCADE
GO
ALTER TABLE [City/Town/Village_Has_Road] CHECK CONSTRAINT [City/Town/Village_Has_Road_fk0]
GO
ALTER TABLE [City/Town/Village_Has_Road] WITH CHECK ADD CONSTRAINT [City/Town/Village_Has_Road_fk1] FOREIGN KEY ([Name]) REFERENCES [City/Town/Village]([Name])
ON UPDATE CASCADE
GO
ALTER TABLE [City/Town/Village_Has_Road] CHECK CONSTRAINT [City/Town/Village_Has_Road_fk1]
GO

ALTER TABLE [Assignment] WITH CHECK ADD CONSTRAINT [Assignment_fk0] FOREIGN KEY ([ID]) REFERENCES [Contractor_Employees]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [Assignment] CHECK CONSTRAINT [Assignment_fk0]
GO
ALTER TABLE [Assignment] WITH CHECK ADD CONSTRAINT [Assignment_fk1] FOREIGN KEY ([Project_ID]) REFERENCES [Project]([Project_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [Assignment] CHECK CONSTRAINT [Assignment_fk1]
GO

ALTER TABLE [Funds] WITH CHECK ADD CONSTRAINT [Funds_fk0] FOREIGN KEY ([Organisation_Name]) REFERENCES [Funding_Organisation]([Organisation_Name])
ON UPDATE CASCADE
GO
ALTER TABLE [Funds] CHECK CONSTRAINT [Funds_fk0]
GO
ALTER TABLE [Funds] WITH CHECK ADD CONSTRAINT [Funds_fk1] FOREIGN KEY ([Project_ID]) REFERENCES [Project]([Project_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [Funds] CHECK CONSTRAINT [Funds_fk1]
GO

