using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace webDatVeXemPhim
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["movieList"] = new List<Movie>();
            Application["userList"] = new List<user>();

            List<user> listU = new List<user>();
            List<MovieTicket> listT = new List<MovieTicket>();
            List<buyedHistory> buyedHistories = new List<buyedHistory>();
            listU.Add(new user("admin01","admin@gmail.com","12345",listT,buyedHistories,0));
            Application["userList"] = listU;

            List<Movie> list = new List<Movie>();
             /*Phim mới*/
            list.Add(new Movie(1, "Joker", "img/Movie_poster/joker_movie1.jpg", "mang Batman ra đây", "Joker từ lâu đã là siêu ác nhân huyền thoại của điện ảnh thế giới. Nhưng có bao giờ bạn tự hỏi, Joker đến từ đâu và điều gì đã biến Joker trở thành biểu tượng tội lỗi của thành phố Gotham? JOKER sẽ là cái nhìn độc đáo về tên ác nhân khét tiếng của Vũ trụ DC – một câu chuyện gốc thấm nhuần, nhưng tách biệt rõ ràng với những truyền thuyết quen thuộc xoay quanh nhân vật mang đầy tính biểu tượng này. Bộ phim đã xuất sắc giành giải thưởng Sư Tử Vàng- Phim Hay Nhất tại LHP Venice lần thứ 76, cùng tràng pháo tay dài 8 phút, và lời khen ngợi dành cho diễn xuất của tài tử Joaquin Phoenix. Một bộ phim không thể bỏ lỡ của tháng 10 năm nay.", 121, 20000, 30000, "kinh dị", 2022, "Mỹ"));
            list.Add(new Movie(2, "Batman", "img/Movie_poster/batman_movie2.jpg", "the Batman", "Tay giết người hàng loạt – The Ridder (Paul Dano) sẽ là kẻ thù nguy hiểm hàng đầu của Batman ở phần phim sắp tới. Tên xấu xa này bị cảnh sát James Gordon và đồng đội bắt giữ đã lâu. Thế nhưng, hóa ra việc nhốt gã sau song sắt chỉ khiến The Ridder phiền phức hơn với Đấng. Penguin (Colin Farrell) thể hiện là kẻ thủ ác thích trực tiếp tạo ra hỗn loạn, muốn đối đầu Batman hơn là chỉ đạo gián tiếp theo cách The Ridder thực hiện.", 160, 50000, 80000, "hành động", 2022, "Mỹ"));
            list.Add(new Movie(3, "The Flash", "img/Movie_poster/theFlash_movie3.jpg", "the Flash (2022)", "The Flash là một trong những bom tấn điện ảnh đang nhận được sự quan tâm nhất của khán giả hiện nay, đặc biệt là những fan ruột của vũ trụ điện ảnh DC. Ngay khi có thông tin bộ phim được bấm máy, nhiều cây viết đã phỏng đoán nhân vật Batman và Superman sẽ bị xóa sổ trong The Flash.", 121, 20000, 30000, "hành động", 2022, "Mỹ"));
            list.Add(new Movie(4, "SpiderMan", "img/Movie_poster/spiderman_movie4.jpg", "No way Home", "“Spider-Man: No Way Home” không chỉ là cái kết cho bộ ba phim (trilogy) của Tom Holland mà còn mở ra cả một tương lai đầy hứa hẹn cho nhân vật. Tác phẩm còn được khen giàu cảm xúc khi viết tiếp chặng đường dang dở của hai phiên cũ bản do Tobey Maguire và Andrew Garfield thể hiện.", 180, 50000, 70000, "hành động", 2022, "Mỹ"));
            list.Add(new Movie(5, "5cm/s", "img/Movie_poster/5cmPerSecond_movie4.jpg", "a Skinkai Makoto film", "Đây là một câu chuyện tình buồn diễn ra tại Nhật Bản, với xuất phát điểm là từ những năm 90 khi Takaki Tono mới 13 tuổi cho tới hiện tại khi anh đã đi làm.", 60, 30000, 40000, "đời thường", 2022, "Nhật Bản"));
            list.Add(new Movie(6, "The Platform", "img/Movie_poster/ThePlatForm_movie6.jpg", "Hố sâu đói khát", "Phiến bê tông chứa thức ăn đi xuống từng tầng một trong nhà tù. Tù nhân ở trên sẽ được ăn no, những kẻ bên dưới sẽ chết đói trong tuyệt vọng. Và cuộc nổi loạn sắp xảy ra.", 121, 90000, 120000, "kinh dị", 2022, "Ba Lan"));
            list.Add(new Movie(7, "Conan", "img/Movie_poster/Conan_movie7.jpg", "Conan: cô dâu Hallowen", "Conan đến một hầm trú ẩn dưới lòng đất, nơi Amuro đang ẩn náu để phá giải quả bom vòng cổ đó và nghe kể về vụ án mà Amuro và các thành viên cùng khóa thời học viện cảnh sát mà bây giờ đã qua đời gặp phải rằng họ bắt gặp Plamya- một kẻ đánh bom hóa trang chưa rõ danh tính ở Shibuya vào 3 năm trước", 121, 20000, 30000, "trinh thám", 2022, "Nhật Bản"));
            list.Add(new Movie(8, "Logan: Người sói", "img/Movie_poster/logan_moive8.png", "trận chiến cuối cùng", "Logan 2017 nói về câu chuyện diễn ra nhiều năm sau khi sự kiện trong X-Men: Days of Future Past kết thúc. Logan thề rằng sẽ không bao giờ vung móng ra nữa và đồng thời khả năng hồi phục của anh cũng đã yếu hơn nhiều. Khi một tổ chức tội ác được cầm đầu bởi Nathaniel Essex, hay còn gọi là Mister Sinister muốn sử dụng những dị nhân còn lại trên thế giới, biến bọn họ trở thành vũ khí sống, Logan buộc phải trở thành Wolverine một lần nữa.", 180, 60000, 90000, "hành động", 2022, "Mỹ"));
            /*Phim hot*/
            list.Add(new Movie(9, "Transformer 3", "img/Movie_poster/transformer_movie9.jpg", "người máy biến hình phần 3", "là một phim điện ảnh hành động khoa học viễn tưởng của Mỹ năm 2011 do Michael Bay đạo diễn dựa trên dòng đồ chơi cùng tên của công ty Hasbro. Đây là phần phim thứ ba trong loạt phim Transformers", 121, 120000, 130000, "hành động", 2022, "Mỹ"));
            list.Add(new Movie(10, "Công viên kỷ jurra", "img/Movie_poster/jurassicWorld_movie10.jpg", "jurassic World", "Hai mươi hai năm sau Công viên kỷ Jura, Isla Nublar bây giờ đã trở thành công viên khủng long thật sự, tên là Jurassic World, ban đầu được hình dung bởi John Hammond. Công viên mới được sở hữu bởi Tập đoàn Masrani. Owen (Chris Pratt), một nhân viên tại chỗ của công viên, đang nghiên cứu hành vi của Velociraptor. Nhiều năm sau, tỉ lệ khách của Jurassic World suy giảm và một sức hút mới, được tạo ra để thu hút lại sự chú ý của khách, đem lại kết quả ngược với mong đợi.", 121, 50000, 90000, "kinh dị", 2022, "Mỹ"));
            list.Add(new Movie(11, "Pacific Rim", "img/Movie_poster/PacificRim_movie11.jpg", "đại chiến thái bình dương", "Đại Chiến Thái Bình Dương 2: Trỗi Dậy kể về bối cảnh 10 năm sau những sự kiện đã diễn ra ở phần 1, Jake Pentecost – truyền nhân duy nhất của huyền thoại Stacker Pentecost đã thực hiện lời hứa với cha mình, gia nhập nhóm người điều khiển Jaeger gồm có Lambert (Scott Eastwood) và Amara chỉ mới 15 tuổi (Cailee Spaeny), cùng nhau xây dựng nên một chiến tuyến chống lại Kaiju. Cuộc xung đột toàn cầu kéo dài giữa những quái vật âm mưu phá hủy thế giới và những robot khổng lồ do con người chế tạo ra nhằm đánh bại lũ quái vật hứa hẹn sẽ là một cuộc chiến cam go và kịch tính khi lũ quái vật giờ đây đã tiến hóa vượt bậc cả về thể lực và trí lực.", 121, 20000, 30000, "hành động", 2022, "Mỹ"));
            list.Add(new Movie(12, "Your name", "img/Movie_poster/yourName_movie12.jpg", "Tên cậu là gì?", "Tên Cậu Là Gì - Your Name kể về Mitsuha – nữ sinh trung học sống ở một thị trấn nhỏ của vùng Itomori. Luôn chán chường với cuộc sống tẻ nhạt ở vùng thôn quê, Mitsuha ao ước kiếp sau được làm một anh chàng đẹp trai sống ở thủ đô Tokyo sôi động. Trong khi đó ở Tokyo, anh chàng Taki rất hài lòng với cuộc sống và công việc làm thêm ở một nhà hàng Italy sau giờ học. Tuy vậy, hằng đêm cậu vẫn mơ thấy mình trong cơ thể một cô gái thôn quê. Đến một hôm khi sự kiện nghìn năm có một là Sao Chổi tiến gần tới Trái đất, Taki và Mitsuha bỗng bị hoán đổi cơ thể. Cứ cách một ngày, Taki lại trở thành Mitsuha khám phá cuộc sống vùng quê và ngược lại, Mitsuha làm anh chàng nam sinh Tokyo háo hức với cuộc sống nơi đô thị ồn ào. Cứ thế, câu chuyện của Mitsuha và Taki diễn ra dẫn dắt khán giả đến những tình huống đặc biệt, dù cả hai chưa bao giờ gặp mặt hay thậm chí là biết tên của nhau.", 121, 20000, 30000, "tình cảm", 2022, "Nhật Bản"));
            list.Add(new Movie(13, "Chú thuật sư", "img/Movie_poster/JujutsuKaisen_movie13.jpg", "trận chiến cuối cùng", "Không còn sống được bao lâu, nam sinh cấp ba Yuji quyết tìm cho ra và nuốt 19 ngón tay còn lại của lời nguyền chết chóc để cậu và nó cùng tan biến.", 121, 70000, 100000, "hành động", 2022, "Nhật Bản"));
            list.Add(new Movie(14, "Overlord", "img/Movie_poster/overlord_movie14.jpg", "Overlord: holy kingdom arc", "Đúng với tên gọi, phim chuyển thể arc truyện cùng tên trong light novel Overlord Vol.12 và 13. Nội dung chính của phim sẽ là cuộc chiến giữa liên minh Ainz Ooal Gown + vương quốc với chúa tể ác ma Jaldabaoth.", 121, 60000, 80000, "kinh dị", 2022, "Nhật Bản"));
            list.Add(new Movie(15, "Zombie Land", "img/Movie_poster/zombieLand_movie15.jpg", "mang Zombie ra đây", "Hai tháng trôi qua kể từ khi một dịch bò điên phát triển thành thành dịch người điên và sau đó trở thành dịch thây ma điên tràn ngập nước Mỹ, biến mọi người thành những thây ma khát máu. Những người còn sống sót sau đại dịch này nhận ra rằng không nên ở gần nhau vì họ có thể bị chết bất cứ lúc nào, nhiều người đã sử dụng tên thành phố họ ở làm biệt danh.", 121, 20000, 30000, "kinh dị", 2022, "Mỹ"));
            list.Add(new Movie(16, "Parasite", "img/Movie_poster/parasite_movie16.jpg", "Ký sinh trùng", "bộ phim theo chân về một gia đình nghèo có kế hoạch trở thành những thành viên của một gia đình giàu có và xâm nhập vào hộ gia đình của họ bằng cách đóng giả là những người không liên quan có trình độ chuyên môn cao.", 121, 20000, 30000, "kinh dị", 2022, "Hàn Quốc"));

            Application["movieList"] = list;

            Application["countPeople"] = 0;

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["login"] = new DateTime();
            Session["userLogin"] = new user();
            if(Application["countPeople"] != null)
            {
                Application.Lock();
                int i = Convert.ToInt32(Application["countPeople"]);
                Application["countPeople"] = ++i;
                Application.UnLock();
            }
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Session["userLogin"] = new user();
            if (Application["countPeople"] != null)
            {
                Application.Lock();
                int i = Convert.ToInt32(Application["countPeople"]);
                Application["countPeople"] = --i;
                Application.UnLock();
            }
        }

        protected void Application_End(object sender, EventArgs e)
        {
            if (Application["countPeople"] != null)
            {
                Application.Lock();
                int i = Convert.ToInt32(Application["countPeople"]);
                Application["countPeople"] = --i;
                Application.UnLock();
            }
        }
    }
}