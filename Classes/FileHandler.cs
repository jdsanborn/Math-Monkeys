using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;


namespace Math_Monkeys.Classes
{
    class FileHandler
    {
        #region Member Variables

            private string filePath;
            private enum MMFileType {None, User, ProblemSet, Assignment, AssignmentAttempt};
        
        #endregion

        #region FileHandler Methods

            private XDocument OpenFile(string fileName, MMFileType fileType)
        {
            if (!File.Exists(fileName))
            {
                XDocument xFile = new XDocument( );
               

                switch (fileType)
                {
  
                    case MMFileType.User:
                                    xFile.Add(
                                        new XElement("users", 
                                            new XElement("user",
                                                new XElement("id", Properties.Settings.Default.DefaltAdminID),
                                                new XElement("type", UserType.Administrator),
                                                new XElement("screenname", Properties.Settings.Default.DefaltAdminName),
                                                new XElement("name",
                                                    new XElement("first", Properties.Settings.Default.DefaltAdminName),
                                                    new XElement("last", Properties.Settings.Default.DefaltAdminName)
                                                ),
                                                new XElement("password",Properties.Settings.Default.DefaltAdminName),
                                                new XElement("loginrecords",
                                                    new XElement("login",
                                                        new XElement("date", DateTime.Now),
                                                        new XElement("duration", string.Empty)
                                                    )
                                                )
                                            )
                                        )
                                    );
                        break;
                    case MMFileType.ProblemSet:
                        xFile.Add(new XElement("problemSets", string.Empty));
                        break;
                    case MMFileType.Assignment:
                        xFile.Add(new XElement("assignments", string.Empty));
                        break;
                    case MMFileType.AssignmentAttempt:
                        xFile.Add(new XElement("assignmentAttempts", string.Empty));
                        break;
                    case MMFileType.None:
                    default:
                        break;

                }

                xFile.Save(fileName);
                
            }
           
            try
            {
                return XDocument.Load(fileName);
            }
            catch (System.IO.IOException ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
                return null;
            }

        }
        
        #endregion

        #region constructors

            private void init()
            {
                filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Properties.Settings.Default.mmFolder);

                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

            }

            public FileHandler()
        {
            init();
        }
        
        #endregion

        #region User Methods

            public User GetUserByID(uint id)
            {
                var users = from user in GetAllUsers()
                               where user.ID == id
                               select user;
                List<User> userList = new List<User>(users);
                return userList.Count > 0 ? userList[0]: null;
            }

            public List<User> GetUserList(UserType userType)
            {
                var userList = from user in GetAllUsers()
                        where user.UserType == userType
                        select user;
                return new List<User>(userList);
            }

            public List<User> GetAllUsers()
            {
                List<User> userList = new List<User>();
                string fileName = Path.Combine(filePath, Properties.Settings.Default.usersFilename);
                XDocument usersDocument;
                               
                try
                {
                    usersDocument = OpenFile(fileName, MMFileType.User);
                    
                    userList = usersDocument.Descendants("user").Select( d =>
                                    new User
                                        {
                                            ID = uint.Parse(d.Element("id").Value),
                                            UserType = (UserType) Enum.Parse(typeof(UserType), d.Element("type").Value, true),
                                            ScreenName = d.Element("screenname").Value,
                                            FirstName = d.Element("name").Element("first").Value,
                                            LastName = d.Element("name").Element("last").Value,
                                            Password = d.Element("password").Value,
                                            LastLoginDate = DateTime.Parse(d.Element("loginrecords").Element("login").Element("date").Value)
                                        }
                                ).ToList();
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
             

                return userList;
            }

            public void SaveNewUser(User user)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.usersFilename);
                      
                try
                {
                    XDocument userFile = OpenFile(fileName, MMFileType.User);

                
                    if (userFile != null)
                    {
                        var newUserNode = new XElement("user",
                            new XElement("id", user.ID),
                            new XElement("type", user.UserType),
                            new XElement("screenname", user.ScreenName),
                            new XElement("name",
                                new XElement("first", user.FirstName),
                                new XElement("last", user.LastName)),
                            new XElement("password", user.Password),
                            new XElement("loginrecords",
                                new XElement("login",
                                    new XElement("date", user.LastLoginDate),
                                    new XElement("duration", string.Empty)
                                            )
                                        )
                        );

                        userFile.Element("users").Add(newUserNode);
                        userFile.Save(fileName);
                    }
                }
                catch ( FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            
            }

            public void UpdateUser(User user)
            { 
                string fileName = Path.Combine(filePath, Properties.Settings.Default.usersFilename);

                try
                {
                    XDocument userFile = OpenFile(fileName, MMFileType.User);

                    if (userFile != null)
                    {
                        var users = from elem in userFile.Descendants("user")
                                    where user.ID == uint.Parse(elem.Element("id").Value)
                                    select elem;

                        foreach (XElement item in users)
                        {
                            item.SetElementValue("type", user.UserType.ToString());
                            item.SetElementValue("screenname", user.ScreenName);
                            item.Element("name").SetElementValue("first", user.FirstName);
                            item.Element("name").SetElementValue("last", user.LastName);
                            item.SetElementValue("password", user.Password);
                            item.Element("loginrecords").Element("login").SetElementValue("date", user.LastLoginDate.Value);
                        }
                    }  
                
                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            }

            public void DeleteUser(User user)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.usersFilename);
                try
                {
                    XDocument userFile = OpenFile(fileName, MMFileType.User);

                    if (userFile != null)
                    {
                        var users = from elem in userFile.Descendants("user")
                                    where user.ID == uint.Parse(elem.Element("id").Value)
                                    select elem;

                        foreach (XElement item in users)
                        {
                            item.Remove();
                        }

                        userFile.Save(fileName);
                    }

                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            }

        #endregion

        #region Assignment Methods

            public Assignment GetAssignmentByID(uint id)
            {
                var assignments = from assign in GetAllAssignments()
                                  where assign.ID == id
                                  select assign;
                List<Assignment> assignmentsList = new List<Assignment>(assignments);
                return assignmentsList.Count > 0 ? assignmentsList[0] : null;
            }

            public List<Assignment> GetAllAssignments()
            { 
                List<Assignment> assignmentList = new List<Assignment>();
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentFilename);
                XDocument usersDocument;

                try
                {
                    usersDocument = OpenFile(fileName, MMFileType.Assignment);

                    assignmentList = usersDocument.Descendants("assignment").Select(d =>
                                    new Assignment
                                    {
                                        ID = uint.Parse(d.Element("id").Value),
                                        UserID = uint.Parse(d.Element("userID").Value),
                                        ProblemSetID = uint.Parse(d.Element("problemSetID").Value),
                                        Goal = double.Parse(d.Element("goal").Value)
                                    }
                                ).ToList();
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
                

                return assignmentList;
            }

            public List<Assignment> GetAssignmentsByUser(User user)
            {
                var assignments = from assign in GetAllAssignments()
                                  where assign.UserID == user.ID
                                  select assign;
                return new List<Assignment>(assignments);
            }

            public List<Assignment> GetAssignmentsByProblemSet(ProblemSet problemSet)
            {
                var assignments = from assign in GetAllAssignments()
                                  where assign.ProblemSetID == problemSet.ID
                                  select assign;
                return new List<Assignment>(assignments);
            }

            public void SaveNewAssignment(Assignment assignment)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentFilename);

                try
                {
                    XDocument assignmentFile = OpenFile(fileName, MMFileType.Assignment);

                    if (assignmentFile != null)
                    {
                        var newAssignmentNode = new XElement("assignment",
                            new XElement("id", assignment.ID),
                            new XElement("userID", assignment.UserID),
                            new XElement("problemSetID", assignment.ProblemSetID),
                            new XElement("goal", assignment.Goal)
                            );
                        assignmentFile.Element("assignments").Add(newAssignmentNode);
                        assignmentFile.Save(fileName);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            }

            public void UpdateAssignment(Assignment assignment)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentFilename);

                try
                {
                    XDocument assignmentFile = OpenFile(fileName, MMFileType.Assignment);

                    if (assignmentFile != null)
                    {
                        var assignments = from elem in assignmentFile.Descendants("assignment")
                                          where assignment.ID == uint.Parse(elem.Element("id").Value)
                                    select elem;

                        foreach (XElement item in assignments)
                        {
                            item.SetElementValue("userID", assignment.UserID.ToString());
                            item.SetElementValue("problemSetID", assignment.ProblemSetID.ToString());
                            item.SetElementValue("goal", assignment.Goal.ToString());
                        }

                        assignmentFile.Save(fileName);
                    }

                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
        
            }

            public void DeleteAssignment(Assignment assignment)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentFilename);
                try
                {
                    XDocument assignmentFile = OpenFile(fileName, MMFileType.Assignment);

                    if (assignmentFile != null)
                    {
                        var assignments = from elem in assignmentFile.Descendants("assignment")
                                    where assignment.ID == uint.Parse(elem.Element("id").Value)
                                    select elem;

                        foreach (XElement item in assignments)
                        {
                            item.Remove();
                        }

                        assignmentFile.Save(fileName);
                    }

                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            }

        #endregion

        #region ProblemSet Methods

            public List<ProblemSet> GetAllProblemSets()
            {

                List<ProblemSet> problemSetsList = new List<ProblemSet>();
                string fileName = Path.Combine(filePath, Properties.Settings.Default.problemSetsFilename);
                XDocument problemSetsDocument;

                try
                {

                    problemSetsDocument = OpenFile(fileName, MMFileType.ProblemSet);

                    problemSetsList = problemSetsDocument.Descendants("problemSet").Select(d =>
                                    new ProblemSet
                                    {
                                        ID = uint.Parse(d.Element("id").Value),
                                        Name = d.Element("name").Value,
                                        Operation = (Operation) Enum.Parse(typeof(Operation), d.Element("Operation").Value, true),
                                        Operand =  d.Element("operands").Descendants("operand").Select( x => 
                                                                                                    new Operand
                                                                                                    {
                                                                                                        rangeMin = int.Parse(x.Element("rangeMin").Value),
                                                                                                        rangeMax = int.Parse(x.Element("rangeMax").Value),
                                                                                                    }).ToArray(),
                                        NumberOfProblems = uint.Parse(d.Element("numberOfProblems").Value)
                                    }
                                ).ToList();
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
                
                return problemSetsList;
            }

            public ProblemSet GetProblemSetByID(uint id)
            {
                var problemsSets = from problemSet in GetAllProblemSets()
                                   where problemSet.ID == id
                                   select problemSet;
                List<ProblemSet> ProblemSetList = new List<ProblemSet>(problemsSets);
                return ProblemSetList.Count > 0 ? ProblemSetList[0] : null;
            }

            public List<ProblemSet> GetProblemSetByOperation(Operation operation)
            {

                var ProblemSetList = from problemSet in GetAllProblemSets()
                               where problemSet.Operation == operation
                               select problemSet;
                return new List<ProblemSet>(ProblemSetList);
            }

            public void SaveNewProblemSet(ProblemSet problemSet)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.problemSetsFilename);

                try
                {
                    XDocument problemSetFile = OpenFile(fileName, MMFileType.ProblemSet);

                    if (problemSetFile != null)
                    {
                       var newproblemSetFileNode = new XElement("problemSet",
                            new XElement("id", problemSet.ID),
                            new XElement("name", problemSet.Name),
                            new XElement("operation", problemSet.Operation),
                            new XElement("operands", problemSet.Operand)
                            );

                        problemSetFile.Element("problemSets").Add(newproblemSetFileNode);
                        problemSetFile.Save(fileName);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            
            }

            public void UpdateProblemSet(ProblemSet problemSet)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.problemSetsFilename);

                try
                {
                    XDocument problemSetFile = OpenFile(fileName, MMFileType.ProblemSet);

                    if (problemSetFile != null)
                    {
                        var problemSets = from elem in problemSetFile.Descendants("problemSet")
                                          where problemSet.ID == uint.Parse(elem.Element("id").Value)
                                          select elem;

                        foreach (XElement item in problemSets)
                        {
                            item.SetElementValue("name", problemSet.Name);
                            item.SetElementValue("operation", problemSet.Operation);
                            item.SetElementValue("operands", problemSet.Operand);
                            item.SetElementValue("numberOfProblems", problemSet.NumberOfProblems);
                        }

                        problemSetFile.Save(fileName);
                    }

                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            }

            public void DeleteProblemSet(ProblemSet problemSet)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.problemSetsFilename);
                try
                {
                    XDocument problemSetFile = OpenFile(fileName, MMFileType.ProblemSet);

                    if (problemSetFile != null)
                    {
                        var problemSets = from elem in problemSetFile.Descendants("problemSet")
                                          where problemSet.ID == uint.Parse(elem.Element("id").Value)
                                          select elem;

                        foreach (XElement item in problemSets)
                        {
                            item.Remove();
                        }

                        problemSetFile.Save(fileName);
                    }

                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            }

        #endregion

        #region AssignmentAttempt Methods

            public List<AssignmentAttempt> GetAllAssignmentAttempts()
            {
                List<AssignmentAttempt> assignmentAttempsList = new List<AssignmentAttempt>();
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentAttempsFilename);
                XDocument assignmentAttempsDocument;

                if (File.Exists(fileName))
                {

                    try
                    {
                        assignmentAttempsDocument = OpenFile(fileName, MMFileType.AssignmentAttempt);

                        assignmentAttempsList = assignmentAttempsDocument.Descendants("assignmentAttemps").Select(d =>
                                        new AssignmentAttempt
                                        {
                                            ID = uint.Parse(d.Element("id").Value),
                                            AssignmentID = uint.Parse(d.Element("assignmentID").Value),
                                            Date = DateTime.Parse(d.Element("date").Value),
                                            Grade = Double.Parse(d.Element("grade").Value),
                                            TimeSpent = TimeSpan.Parse(d.Element("timeSpent").Value)
                                        }
                                    ).ToList();
                    }
                    catch (System.ArgumentOutOfRangeException ex)
                    {
                        System.Diagnostics.Debug.Write(ex.Message);
                    }
                }

                return assignmentAttempsList;
            }

            public AssignmentAttempt GetAssignmentAttemptByID(uint id)
            {
                var assignmentAttempts = from assignmentAttempt in GetAllAssignmentAttempts()
                                         where assignmentAttempt.ID == id
                                         select assignmentAttempt;
                List<AssignmentAttempt> assignmentAttemptList = new List<AssignmentAttempt>(assignmentAttempts);
                return assignmentAttemptList.Count > 0 ? assignmentAttemptList[0] : null;
            }

            public List<AssignmentAttempt> GetAssignmentAttemptsByAssignmentID(uint id)
            {
                var assignmentAttempts = from assignmentAttempt in GetAllAssignmentAttempts()
                                         where assignmentAttempt.AssignmentID == id
                                         select assignmentAttempt;

                return  new List<AssignmentAttempt>(assignmentAttempts);
            }

            public List<AssignmentAttempt> GetAssignmentAttemptsByDateRange(DateTime startDate, DateTime endDate)
            {
                var assignmentAttempts = from assignmentAttempt in GetAllAssignmentAttempts()
                                         where assignmentAttempt.Date >= startDate
                                            && assignmentAttempt.Date <= endDate
                                         select assignmentAttempt;

                return new List<AssignmentAttempt>(assignmentAttempts);
            }

            public void SaveNewAssignmentAttempt(AssignmentAttempt assignmentAttempt)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentAttempsFilename);

                try
                {
                    XDocument assignmentAttemptFile = OpenFile(fileName, MMFileType.AssignmentAttempt);

                    if (assignmentAttemptFile != null)
                    {
                        var newAssignmentAttemptFileNode = new XElement("assignmentAttempt",
                             new XElement("id", assignmentAttempt.ID),
                             new XElement("assignmentID", assignmentAttempt.AssignmentID),
                             new XElement("date", assignmentAttempt.Date),
                             new XElement("grade", assignmentAttempt.Date),
                             new XElement("timeSpent", assignmentAttempt.Date)
                             );

                        assignmentAttemptFile.Element("assignmentAttempts").Add(newAssignmentAttemptFileNode);
                        assignmentAttemptFile.Save(fileName);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            
            }

            public void UpdateAssignmentAttempt(AssignmentAttempt assignmentAttempt)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentAttempsFilename);

                try
                {
                    XDocument assignmentAttemptFile = OpenFile(fileName, MMFileType.AssignmentAttempt);

                    if (assignmentAttemptFile != null)
                    {
                        var assignmentAttempts = from elem in assignmentAttemptFile.Descendants("assignmentAttempt")
                                          where assignmentAttempt.ID == uint.Parse(elem.Element("id").Value)
                                          select elem;

                        foreach (XElement item in assignmentAttempts)
                        {
                            item.SetElementValue("AssignmentID", assignmentAttempt.AssignmentID);
                            item.SetElementValue("Date", assignmentAttempt.Date);
                            item.SetElementValue("grade", assignmentAttempt.Grade);
                            item.SetElementValue("timeSpent", assignmentAttempt.TimeSpent);
                        }

                        assignmentAttemptFile.Save(fileName);
                    }

                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            }

            public void DeleteAssignmentAttempt(AssignmentAttempt assignmentAttempt)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentAttempsFilename);
                try
                {
                    XDocument assignmentAttemptFile = OpenFile(fileName, MMFileType.AssignmentAttempt);

                    if (assignmentAttemptFile != null)
                    {
                        var assignmentAttempts = from elem in assignmentAttemptFile.Descendants("assignmentAttempt")
                                          where assignmentAttempt.ID == uint.Parse(elem.Element("id").Value)
                                          select elem;

                        foreach (XElement item in assignmentAttempts)
                        {
                            item.Remove();
                        }

                        assignmentAttemptFile.Save(fileName);
                    }

                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            }

        #endregion
    }
}
