$(document).ready(function () {
    // LOAD FRONT END DATA
    menu_title = '<a href="/Citizen/MedicalFormList">Danh sách tờ khai</a>'
    $('#function-navigation-bar-title').html(menu_title)

    homepage = '<a href="/Home">Trang chủ</a>'
    $('#homepage-path').html(homepage)

    subpage = '<a href="/Citizen/MedicalFormSubmit">Khai báo</a>'
    $('#subpage-path').html(subpage)

    selected_function = '<a href="/Citizen/MedicalFormList">Danh sách tờ khai</a>'
    $('#selected-function-path').html(selected_function)

    $('#function-menu-title').text('Trang khai báo y tế')

    menu = '<br><a href="/Citizen/MedicalFormSubmit"><li>Tờ khai y tế</li></a>'
    menu += '<br><a href="/Citizen/MedicalFormList"><li>Danh sách tờ khai</li></a>'

    $('#function-menu-list').find('ul').html(menu)

    var today = new Date()
    var day = ('0' + today.getDate()).slice(-2)
    var month = ('0' + (today.getMonth() + 1)).slice(-2)
    var today = today.getFullYear() + '-' + (month) + '-' + (day)
    $('#input-date').val(today)
    // END LOAD FRONT END DATA

    // HANDLE ACTION
    $('#btn-filter-org').click(function () {

        selectformlist()
    })

    function selectformlist() {
        formdate = $('#form-date').val()

        // filleddate = $('#input-date').val()
        // if (new Date (filleddate).getTime() > new Date().getTime()){
        //     alert('Ngày khai báo không hợp lệ!')
        //     return
        //

        $.ajax({
            cache: false,
            url: '/Citizen/MedicalList',
            type: 'POST',
            data: { formdate: formdate },
            success: function (result) {
                if (result.message.substring(0, 3) == 'ORA') {    //EXCEPTION
                    alert(result.message)
                }
                if (result.message == 'NoForm') {
                    PopupConfirm('Bạn chưa khai báo y tế trong vòng ' + formdate + ' ngày!')
                }
                $('#holder-form-medical').html(result.html);
            },
            error: function (error) {
                // $('body').html(error)
                alert('error')
            }
        })
    }
})

var PopupConfirm = function (message) {
    $('.form-message').html(message)
    $('#form-popup-confirm').css('display', 'grid')
    $('#gradient-bg-faded').css('display', 'block')
    $('#form-popup-confirm').find('.btn-confirm').click(function () {
        $('#form-popup-confirm').css('display', 'none')
        $('#gradient-bg-faded').css('display', 'none')
    })
}
