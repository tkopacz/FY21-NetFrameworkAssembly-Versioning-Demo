For /f "tokens=1,2,3,4,5 delims=-./ " %%a in ('date /T') do set CDate=%%d-%%c-%%b
For /f "tokens=1,2,3,4,5 delims=:,. " %%a in ( "%time%" ) do set CTime=%%a-%%b-%%c
echo %CDate%
echo %CTime%
set tagf=c-%CDate%-%CTime%
echo %tagf%
git tag %tagf%
git push origin %tagf%
