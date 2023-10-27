#include<iostream>
#include<fstream>
#include<iomanip>
using namespace std;

//the class that stores data
class student 
{
  int rollno;
  char name[50];
  int eng_marks, math_marks, sci_marks, cs_marks, hin_marks;
  double average;
  char grade;

  public:
  void getdata();
  void showdata() const;
  void calculate();
  int retrollno() const;
}

void student::calculate()
{
  average = (eng_marks + math_marks + sci_marks + cs_marks + hin_marks)/5.0;
  if(average >= 90) 
    grade = 'A';
  else if(average >= 75)
    grade = 'B';
  else if(average >= 50)
    grade = 'C';
  else
    grade = 'F';
}

void student::getdata()
{
  cout<<"Enter student's roll number: ";
  cin>>rollno;

  cout<<"Enter Student's name: ";
  cin.ignore();
  cin.getline(name,50);

  cout<<"\n\nEnter Student's marks : "<<endl;
  cout<<"All marks should be out of 100";

  cout<<"Enter marks in English : ";
  cin>>eng_marks;
  
  cout<<"Enter marks in Maths: ";
  cin>>math_marks;

  cout<<"Enter marks in Science : ";
  cin>>sci_marks;

  cout<<"Enter marks in cs : ";
  cin>>cs_marks;

  cout<<"Enter marks in Hindi : ";
  cin>>hin_marks;
  calculate();
}

void student::showdata() const
{
  cout<<"\nRoll number of Student : "<<rollno;
  cout<<"\nName of the Student : "<<name;
  cout<<"\nEnglish : "<<eng_marks;
  cout<<"\nMaths : "<<math_marks;
  cout<<"\nScience : "<<sci_marks;
  cout<<"\nComputer Science : "<<cs_marks;
  cout<<"\nHindi : "<<hin_marks;

  cout<<"Average marks : "<<average;
  cout<<"\nGrade of student is : "<<grade;
}
