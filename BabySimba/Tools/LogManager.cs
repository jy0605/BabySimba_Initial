using System.IO;

namespace BabySimba.Tools
{
    public class LogManager
    {
        // 외부에서 볼 필요는 없을 것 같으니 private로.
        private string _path;

        // path가 안들어오는 생성자
        # region Constructors
        // 1) 인자를 받지 않는 생성자의 경우 현재 경로\Log 폴더를 _path로 지정하도록.
        //public LogManager()
        //    : this() // 인자를 받는 생성자를 이용하는 방법으로 바꿈. : this() 의 경우, 생성자를 가리킴.
        //{
        //    // Log 폴더를 새로 생성해서 그 안에 적는것으로 하자. 깔끔하게
        //    _path = System.IO.Path.Combine(Application.Root, "Log"); 
        //    _SetLogPath();
        //}
        // path가 들어오는 생성자
        public LogManager(string path)
        {
            _path = path;
            _SetLogPath();
        }

        public LogManager()
            : this(Path.Combine(Application.Root, "Log")) { } // 상기 1)을 변형해서, 인자를 받는 생성자를 이용하는 방법으로 바꿈. : this() 의 경우, 생성자를 가리킴.
                                                              // 로그파일이 저장될 경로를 만들어서 경로를 인자로 받는 생성자를 다시 호출하는 방법임.
                                                              // 이렇게되면, 코드 수정해야 할 때 첫 번째 생성자 함수만 수정하면 됨. 깔끔해짐.
                                                              // 반드시 중괄호를 붙여주어야함!
        #endregion

        #region Methods
        // 보통 name 앞에 _를 붙이면 private라는 의미인 것 같다.
        // 이제 이걸 생성자에서 호출하면 됨
        private void _SetLogPath()
        {
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);

            string logFile = DateTime.Now.ToString("yyyyMMdd") + ".txt";
            _path = Path.Combine(_path, logFile);
        }

        // write log, one line
        public void Write(string data)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_path, true)) // 파일이 없으면 생성시키고, 있으면 open하도록. (append 모드 true)
                {
                    sw.Write(data); // 기록하고 줄바꿈X
                }
            }
            catch (Exception ex) { } // 혹시나 있을 수 있는 exception을 위해서. exception 발생하면 그냥 pass 되도록. log때문에 crash되는 상황을 방지.

        }

        // write log, new line after.
        public void WriteLine(string data)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_path, true)) // 파일이 없으면 생성시키고, 있으면 open하도록. (append 모드 true)
                {
                    // 이렇게 찍히겠죠. => 20220421 21:47:46    Processing 101...
                    sw.WriteLine(System.DateTime.Now.ToString("yyyyMMdd HH:mm:ss\t") + data); // 기록하고 줄바꿈O
                }
            }
            catch(Exception ex) { }
        }
        #endregion
    }
}
