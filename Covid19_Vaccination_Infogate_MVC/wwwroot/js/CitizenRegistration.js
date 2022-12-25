$(document).ready(function () {
    // LOAD FRONT END DATA
    menu_title = '<a href="/Citizen/Registration">Lịch đăng ký tiêm chủng</a>'
    $('#function-navigation-bar-title').html(menu_title)

    homepage = '<a href="/Home">Trang chủ</a>'
    $('#homepage-path').html(homepage)

    subpage = '<a href="/Citizen/Profile">Công dân</a>'
    $('#subpage-path').html(subpage)

    selected_function = '<a href="/Citizen/Registration">Lịch đăng ký tiêm chủng</a>'
    $('#selected-function-path').html(selected_function)

    $('#function-menu-title').text('Trang công dân')

    menu = '<br><a href="/Citizen/AccountInfo"><li>Thông tin tài khoản</li></a>'
    menu += '<br><a href="/Citizen/Profile"><li>Thông tin công dân</li></a>'
    menu += '<br><a href="/Citizen/Registration"><li>Lịch đăng ký tiêm chủng</li></a>'
    menu += '<br><a href="/Citizen/Certificate"><li>Chứng nhận tiêm chủng</li></a>'
    menu += '<br><a href="#"><li>Tra cứu thông tin</li></a>'
    menu += '<br><a href="#"><li>Thêm người thân</li></a>'
    $('#function-menu-list').find('ul').html(menu)

    // END LOAD FRONT END DATA


    // LOAD REGISTRATION
    LoadRegistration()

    $('#btn-filter-registration').click(function () {
        LoadRegistration()
    })

    function LoadRegistration() {
        status = $('#status').val()
        vaccine = $('#vaccine').val()
        time = $('#time').val()
        $.ajax({
            cache: false,
            url: '/Citizen/LoadRegistration',
            type: 'POST',
            data: {status: status, vaccine: vaccine, time: time },
            success: function (data) {
                if (data.substring(0, 3) == 'ORA') {    //EXCEPTION
                    alert(data)
                    return
                }
                $('#list-registration').html(data)
            },
            error: function (error) {
            }
        })
    }
    // END LOAD REGISTRATION

    // CANCEL REGISTRATION
    $('#list-registration').on('click', '.btn-cancel-registration', function () {
        // $('#form-popup-confirm-cancel-registration').find('.form-message').html('Xác nhận hủy đăng ký tiêm chủng?')
        // $('#form-popup-confirm-cancel-registration').css('display', 'grid')
        // $('#gradient-bg-faded').css('display', 'block')

        if (confirm('Xác nhận hủy đăng ký tiêm chủng?')) {
            SchedID = $(this).parent().parent().parent().attr('id')
            // $('#form-popup-confirm').find('.btn-confirm').click(function () {
                CancelRegistration(SchedID)
            // })
        }
    })



    function CancelRegistration(SchedID) {
        $.ajax({
            cache: false,
            url: '/Citizen/CancelRegistration',
            type: 'POST',
            data: { SchedID: SchedID },
            success: function (data) {
                if (data.substring(0, 3) == 'ORA') {    //EXCEPTION
                    alert(data)
                    return
                }
                if (data == 'CancelRegistration')
                    location.reload()
            },
            error: function (error) {
            }
        })
    }
    // END CANCEL REGISTRATION
})