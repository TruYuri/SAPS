public enum ApplicationStatus { Cancel, Remove, Modify, Approve, Reject } // tells the main app what to do with ApplicationEditor results
public enum Gender { Male, Female } // for application editing and searching
public enum StudentType { Undergraduate, Graduate } // for application filtering
public enum Stage { Rejected, Lower, Higher, Approved } // for application status
public enum Vote { Reject, Undecided, Approve } // for voting
public enum EventStatus { Cancel, Remove, Modify, Create } // for both telling EventEditor how to handle UI and its return code
enum UserType { All, UPA, UPC, GPC, GPCC, None } // for User authentication and filtering
